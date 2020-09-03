///
/// 프로세스의 화면 캡쳐
/// @Author Chanwoo Gwon, Yonsei University Researcher, since 2020.05
/// @Date 2020.09.
///

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PeakDetector.DetectiveProcess {
	class CaptureProcess {
        [DllImport("GDI32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int nxDest, int nyDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("GDI32.dll")]
        static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int width, int nHeight);

        [DllImport("GDI32.dll")]
        static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("GDI32.dll")]
        static extern IntPtr DeleteDC(IntPtr hdc);

        [DllImport("GDI32.dll")]
        static extern IntPtr DeleteObject(IntPtr hObject);

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("GDI32.dll")]
        static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

        const int SRCCOPY = 0x00CC0020;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        /// <summary>
        /// 프로세스 Handle을 이용해 화면을 캡쳐
        /// 출처 :https://www.developerfusion.com/code/4630/capture-a-screen-shot/
        /// </summary>
        /// <param name="handle">캡쳐할 프로세스의 Handle 포인터</param>
        /// <returns>스크린샷 이미지 오브젝트</returns>
        public Image CaptureProcessHandle(IntPtr handle) {
            // 프로세스의 메모리 DC
            IntPtr hdcSrc = GetWindowDC(handle);
            // 윈도우 크기 계산
            RECT windowRect;
            GetWindowRect(handle, out windowRect);
            int width = windowRect.Right - windowRect.Left;
            int height = windowRect.Bottom - windowRect.Top;
            // 복사할 DC 생성
            IntPtr hdcDest = CreateCompatibleDC(hdcSrc);
            // Bitmap 생성
            IntPtr hBitmap = CreateCompatibleBitmap(hdcSrc, width, height);
            // Bitmap 오브젝트 선택
            IntPtr hOld = SelectObject(hdcDest, hBitmap);
            // Bitmap 생성
            BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, SRCCOPY);

            // 작업 종료 및 메모리 해제
            SelectObject(hdcDest, hOld);
            DeleteDC(hdcDest);
            ReleaseDC(handle, hdcSrc);

            // 이미지 생성
            Image img = Image.FromHbitmap(hBitmap);
            // 메모리 해제
            DeleteObject(hBitmap);
            return img;
        }
    }
}
