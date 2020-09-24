using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PeakDetector.DetectiveProcess {
    /// <summary>
    /// 1. 그래프 캡처 이미지 파일을 로컬에 저장
    /// 2. 전체 프로그램에서 그래프 영역 계산 
    /// 3. 전체 프로그램 캡처 이미지를 그래프 영역으로 자르기
    /// @Author Mina Kim, Yonsei University Researcher, since 2020.08
    /// @Date 2020.09.21
    /// </summary>

    public class Capture {

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        private MainForm mainForm;
        private const String FILE_PATH = "C:\\temp\\ABR_capture";
        private const int SW_RESTORE = 9;

        public Capture(MainForm mainForm) {

            this.mainForm = mainForm;
        }

        /// <summary>
        /// 그래프 캡처 이미지 파일을 로컬에 저장
        /// </summary>
        /// <param name="tbXValue">캡처 시작 x 값</param>
        /// <param name="tbYValue">캡처 시작 y 값</param>
        /// <param name="tbWidth">캡처 영역 넓이</param>
        /// <param name="tbHeight">캡처 영역 높이</param>
        public void saveGraphScreenshotByFile(TextBox tbXValue, TextBox tbYValue, TextBox tbWidth, TextBox tbHeight) {

            string fileName = "capture-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string fullpath = FILE_PATH + "\\" + fileName + ".png";

            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false) 
            {
                directoryInfo.Create();
            }

            Rectangle graphBound = getGraphBound(tbXValue, tbYValue, tbWidth, tbHeight);
            Bitmap ImageGraph = doCaptureProcess(graphBound);

            ImageGraph.Save(fullpath, ImageFormat.Png);
        }

        /// <summary>
        /// 전체 프로그램에서 그래프 영역 계산
        /// </summary>
        /// <param name="tbXValue">캡처 시작 x 값</param>
        /// <param name="tbYValue">캡처 시작 y 값</param>
        /// <param name="tbWidth">캡처 영역 넓이</param>
        /// <param name="tbHeight">캡처 영역 높이</param>
        /// <returns>그래프 영역 값</returns>
        private Rectangle getGraphBound(TextBox tbXValue, TextBox tbYValue, TextBox tbWidth, TextBox tbHeight) {

            Rectangle graphBound = new Rectangle();

            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
       
            graphBound.X = Int32.Parse(tbXValue.Text);
            graphBound.Y = Int32.Parse(tbYValue.Text);
            graphBound.Width = Int32.Parse(tbWidth.Text);
            graphBound.Height = Int32.Parse(tbHeight.Text);

            return graphBound;
        }

        /// <summary>
        /// 전체 프로그램 캡처 이미지를 그래프 영역으로 자르기
        /// </summary>
        /// <param name="graphBound">그래프 영역 값</param>
        /// <returns>그래프 이미지</returns>
        private Bitmap doCaptureProcess(Rectangle graphBound) {

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

        public Rectangle getCaptureBound(Panel panelCaptureArea) {

            Rectangle rect = new Rectangle();
            rect.Width = panelCaptureArea.Width - 2;
            rect.Height = panelCaptureArea.Height - 2;

            Control control = (Control)panelCaptureArea;
            Point locationOnForm = control.Parent.PointToScreen(control.Location);

            rect.X = locationOnForm.X + 1;
            rect.Y = locationOnForm.Y + 1;

            return rect;
        }

        public void doCaptureByFile(Panel panelCaptureArea) {

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

        private void ScreenshotByFile(String filepath, String filename, ImageFormat format, Rectangle bounds) {

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
