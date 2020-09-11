using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PeakDetector.DetectiveProcess
{
    public class Capture
    {
        private MainForm mainForm;
        private const String FILE_PATH = "C:\\temp\\ABR_capture";

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        public Capture(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public Rectangle getCaptureBound(Panel panelCaptureArea)
        {
            Rectangle rect = new Rectangle();
            rect.Width = panelCaptureArea.Width - 2;
            rect.Height = panelCaptureArea.Height - 2;

            Control control = (Control)panelCaptureArea;
            Point locationOnForm = control.Parent.PointToScreen(control.Location);

            rect.X = locationOnForm.X + 1;
            rect.Y = locationOnForm.Y + 1;

            return rect;
        }
        public void doCaptureByFile(Panel panelCaptureArea)
        {
            String fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            ImageFormat imageFormat = ImageFormat.Png;

            Rectangle bound = this.getCaptureBound(panelCaptureArea);

            this.ScreenshotByFile(FILE_PATH, fileName, imageFormat, bound);
        }

        public void doGraphCaptureByFile()
        {
            string fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string fullpath = FILE_PATH + "\\" + fileName + ".png";

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            Process proc = Process.GetProcessesByName("AEPCopy")[0];
            CaptureProcess processor = new CaptureProcess();
            Image image = processor.CaptureProcessHandle(proc.MainWindowHandle);

            int x = (int)(image.Width * 0.03); 
            int y = (int)(image.Height * 0.11);
            int width = (int)(image.Width * 0.37);
            int height = (int)(image.Height * 0.81);
            
            Bitmap croppedBitmap = new Bitmap(image);
            croppedBitmap = croppedBitmap.Clone(
                    new Rectangle(x, y, width, height), PixelFormat.DontCare);

            croppedBitmap.Save(fullpath, ImageFormat.Png);
        }

        private void ScreenshotByFile(String filepath, String filename, ImageFormat format, Rectangle bounds)
        {
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.X, bounds.Y), Point.Empty, bounds.Size, CopyPixelOperation.SourceCopy);
                }

                string fullpath = filepath + "\\" + filename + ".png";
                bitmap.Save(fullpath, format);
            }
        }
    }
}
