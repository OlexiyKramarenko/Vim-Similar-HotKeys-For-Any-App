using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class WinApiWrapper
    {

        public bool KeyIsPressed(VirtualKey key) =>
            (WinApi.GetAsyncKeyState((int)key) & 0x8000) != 0;


        public WinApiWrapper SendText(IntPtr programHandle, string text)
        {
            SendMessageW(programHandle, WM_SETTEXT, 0, text);
            //System.Windows.Forms.SendKeys.Send(text);
            return this;
        }

        public int GetWindowBottomY(IntPtr hwnd) => GetWindowRect(hwnd).Bottom;
        public int GetWindowTopY(IntPtr hwnd) => GetWindowRect(hwnd).Top;
        public int GetWindowLeftX(IntPtr hwnd) => GetWindowRect(hwnd).Left;
        public int GetWindowRightX(IntPtr hwnd) => GetWindowRect(hwnd).Right;


        public WinApiWrapper SetWindowPos(IntPtr hwnd, POINT topLeftAppWindowCorner, int width, int height)
        {
            WinApi.SetWindowPos(hwnd, IntPtr.Zero,
                topLeftAppWindowCorner.X,
                topLeftAppWindowCorner.Y,
                topLeftAppWindowCorner.X + width,
                topLeftAppWindowCorner.Y + height,
                SetWindowPosFlags.ShowWindow);

            return this;
        }

        public WinApiWrapper Wait(int milliSeconds = 0)
        {
            Thread.Sleep(milliSeconds);
            return this;
        }

        #region Private Methods

        protected POINT GetCursorScreenPosition()
        {
            POINT lpPoint;
            bool success = WinApi.GetCursorPos(out lpPoint);
            if (!success)
            {
                throw new InvalidOperationException("Cannot find cursor position.");
            }

            return lpPoint;
        }

        protected WinApiWrapper LeftMouseClick(int x, int y) =>
            MouseClick(x, y, MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);

        protected WinApiWrapper RightMouseClickRelatedToTopLeftCornerOfScreen(POINT p) =>
            RightMouseClick(p.X, p.Y);

        protected WinApiWrapper RightMouseClick(int x, int y) =>
            MouseClick(x, y, MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP);

        protected int XScreenToWindow(int screenX)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int windowX = screenX * 65536 / sx;
            return windowX;
        }

        protected int YScreenToWindow(int screenY)
        {
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int windowY = screenY * 65536 / sy;
            return windowY;
        }

        protected WinApiWrapper MouseMove(int x, int y)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int dx = x * 65536 / sx;
            int dy = y * 65536 / sy;
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, dwData: 0, UIntPtr.Zero);
            return this;
        }

        protected WinApiWrapper MouseClick(int x, int y, uint down, uint up)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int dx = x * 65536 / sx;
            int dy = y * 65536 / sy;
            WinApi.mouse_event(down | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, 0, UIntPtr.Zero);
            Thread.Sleep(400);
            WinApi.mouse_event(up | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, 0, UIntPtr.Zero);
            return this;
        }

        protected Rect GetWindowRect(IntPtr hwnd)
        {
            var rect = new WinApi.Rect();
            WinApi.GetWindowRect(hwnd, ref rect);
            return rect;
        }

        #endregion

    }
}
