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

        private const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

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

        public void doFullCaptureByFile()
        {

            String fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            ImageFormat imageFormat = ImageFormat.Png;

            Rectangle bound = Screen.PrimaryScreen.WorkingArea;

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

        public void showWindowABR() {
            Process proc = Process.GetProcessesByName("AEPCopy")[0];
            // SetForegroundWindow(proc.MainWindowHandle);

            // 프로세스의 화면을 캡쳐
            // 저장 방식은 다른 캡쳐 방법과 동일
            // 정리 부탁드립니다^^ (Chanwoo Gwon, 2020.09.03)
            CaptureProcess processor = new CaptureProcess();
            Image bit = processor.CaptureProcessHandle(proc.MainWindowHandle);

            string fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false) {
                directoryInfo.Create();
            }

            string fullpath = FILE_PATH + "\\" + fileName + ".png";
            bit.Save(fullpath, ImageFormat.Png);
        }
    }
}
