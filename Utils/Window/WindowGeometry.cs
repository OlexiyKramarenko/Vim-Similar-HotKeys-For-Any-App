using System;
using System.Drawing;
using static Utils.WinApi.WinApi;

namespace Utils.Window
{
    public class WindowGeometry
    {
        public IntPtr Hwnd { get; }

        private WindowGeometry(IntPtr hwnd)
        {
            Hwnd = hwnd;
        }

        public static WindowGeometry Create(IntPtr ptr) =>
            new WindowGeometry(ptr);

        public Point InCenter => 
           new Point(LeftX + Width / 2, TopY + Height / 2);


        public Point FromLeftBottom(int dx, int dy) => 
           new Point(LeftX + dx, BottomY + dy);


        public Point FromLeftTop(int dx, int dy) =>
           new Point(LeftX + dx, TopY + dy);


        public Point FromRightBottom(int dx, int dy) => 
           new Point(RightX + dx, BottomY + dy);


        public Point FromRightTop(int dx, int dy) => 
           new Point(RightX + dx, TopY + dy);


        public Point FromTopLeft => 
           new Point(CursorScreenPosition.X - LeftX, CursorScreenPosition.Y - TopY);


        public int Width => RightX - LeftX;
        public int Height => BottomY - TopY;
        public int BottomY => GetWindowRect(Hwnd).Bottom;
        public int TopY => GetWindowRect(Hwnd).Top;
        public int LeftX => GetWindowRect(Hwnd).Left;
        public int RightX => GetWindowRect(Hwnd).Right;

        #region Private Methods

        private Point CursorScreenPosition
        {
            get
            {
                POINT lpPoint;
                bool success = GetCursorPos(out lpPoint);
                if (!success)
                {
                    throw new InvalidOperationException("Cannot find cursor position.");
                }

                return new Point(lpPoint.X, lpPoint.Y);
            }
        }

        private Rect GetWindowRect(IntPtr hwnd)
        {
            var rect = new Rect();
            WinApi.WinApi.GetWindowRect(hwnd, ref rect);
            return rect;
        }

        private int XScreenToWindow(int screenX)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int windowX = screenX * 65536 / sx;
            return windowX;
        }

        private int YScreenToWindow(int screenY)
        {
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int windowY = screenY * 65536 / sy;
            return windowY;
        }

        #endregion

    }
}
