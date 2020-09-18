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
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        private MainForm mainForm;
        private const String FILE_PATH = "C:\\temp\\ABR_capture";
        private const int SW_RESTORE = 9;

        public Capture(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void saveGraphScreenshotByFile(TextBox ResolutionWidth, TextBox ResolutionHeight)
        {
            string fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string fullpath = FILE_PATH + "\\" + fileName + ".png";

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            Rectangle graphBound = getGraphBound(ResolutionWidth, ResolutionHeight);
            Bitmap ImageGraph = doCaptureProcess(graphBound);

            ImageGraph.Save(fullpath, ImageFormat.Png);

        }

        private Bitmap doCaptureProcess(Rectangle graphBound)
        {
            Process proc = Process.GetProcessesByName("AEPCopy")[0];
            CaptureProcess processor = new CaptureProcess();
            Image image = processor.CaptureProcessHandle(proc.MainWindowHandle);

            using (Bitmap croppedBitmap = new Bitmap(image))
            {
                Bitmap bitmap = croppedBitmap.Clone(
                    new Rectangle(graphBound.X, graphBound.Y, graphBound.Width, graphBound.Height), PixelFormat.DontCare);
                return bitmap;
            }       
        }

        private Rectangle getGraphBound(TextBox ResolutionWidth, TextBox ResolutionHeight)
        {
            Rectangle graphBound = new Rectangle();

            int width;
            int height;

            if (ResolutionWidth.Text.Equals("") == true || ResolutionHeight.Text.Equals("") == true)
            {
                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;
            }
            width = Int32.Parse(ResolutionWidth.Text);
            height = Int32.Parse(ResolutionHeight.Text);

            graphBound.X = (int)(width * 0.0296875);//0.03
            graphBound.Y = (int)(height * 0.10925926); //0.11
            graphBound.Width = (int)(width * 0.36979167); //0.37
            graphBound.Height = (int)(height * 0.77962963);//0.78

            return graphBound;
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
