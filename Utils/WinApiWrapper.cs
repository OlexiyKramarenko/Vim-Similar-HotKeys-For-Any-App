using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class WinApiWrapper
    {
        public POINT GetCursorWindowPositionFromTopLeftCornerOfWindow(IntPtr hwnd)
        {
            var pos = GetCursorScreenPosition();

            var dx = GetWindowLeftX(hwnd);
            var dy = GetWindowTopY(hwnd);

            var res = new POINT(pos.X - dx, pos.Y - dy);

            return res;
        }

        public POINT GetCursorScreenPosition()
        {
            POINT lpPoint;
            bool success = WinApi.GetCursorPos(out lpPoint);
            if (!success)
            {
                throw new InvalidOperationException("Cannot find cursor position.");
            }

            return lpPoint;
        }

        public void MouseMoveToBottomLeftCornerOfWindow(IntPtr hwnd, POINT point)
        {
            MouseMove(
               x: GetWindowLeftX(hwnd) + point.X,
               y: GetWindowBottomY(hwnd) + point.Y);
        }

        public void MouseMoveToBottomRightCornerOfWindow(IntPtr hwnd, POINT point)
        {
            MouseMove(
               x: GetWindowRightX(hwnd) + point.X,
               y: GetWindowBottomY(hwnd) + point.Y);
        }

        public void MouseMoveToTopRightCornerOfWindow(IntPtr hwnd, POINT point)
        {
            MouseMove(
               x: GetWindowRightX(hwnd) + point.X,
               y: GetWindowTopY(hwnd) + point.Y);
        }

        public void MouseMoveToTopLeftCornerOfWindow(IntPtr hwnd, POINT point)
        {
            MouseMove(
               x: GetWindowLeftX(hwnd) + point.X,
               y: GetWindowTopY(hwnd) + point.Y);
        }

        public int XScreenToWindow(int screenX)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int windowX = screenX * 65536 / sx;
            return windowX;
        }

        public int YScreenToWindow(int screenY)
        {
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int windowY = screenY * 65536 / sy;
            return windowY;
        }

        private void MouseMove(int x, int y)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int dx = x * 65536 / sx;
            int dy = y * 65536 / sy;
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, dwData: 0, UIntPtr.Zero);
        }

        public void MouseWheel(int distance)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, distance, UIntPtr.Zero);
        }

        public WinApiWrapper LeftClickOnCursorPos()
        {
            var pos = GetCursorScreenPosition();
            LeftMouseClick(pos.X, pos.Y);
            return this;
        }

        public WinApiWrapper RightClickOnCursorPos()
        {
            var pos = GetCursorScreenPosition();
            RightMouseClick(pos.X, pos.Y);
            return this;
        }

        public WinApiWrapper SendKeys(VirtualKeyStates holdKey, VirtualKeyStates pressKey)
        {
            SendKeyDown(holdKey);
            SendKey(pressKey);
            SendKeyUp(holdKey);
            return this;
        }

        public WinApiWrapper SendKey(VirtualKeyStates key)
        {
            SendKeyDown(key);
            SendKeyUp(key);
            return this;
        }

        public WinApiWrapper SendKeyDown(VirtualKeyStates key)
        {
            WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, UIntPtr.Zero);
            return this;
        }

        public WinApiWrapper SendKeyUp(VirtualKeyStates key)
        {
            WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
            return this;
        }

        public bool KeyIsPressed(VirtualKeyStates key) =>
            (WinApi.GetAsyncKeyState((int)key) & 0x8000) != 0;

        public bool KeysArePressed(VirtualKeyStates key1, VirtualKeyStates key2) =>
            KeyIsPressed(key2) && KeyIsPressed(key1);

        public bool KeysArePressed(VirtualKeyStates key1, VirtualKeyStates key2, VirtualKeyStates key3) =>
            KeysArePressed(key1, key2) && KeyIsPressed(key3);

        public WinApiWrapper SendText(IntPtr programHandle, string text)
        {
            SendMessageW(programHandle, WM_SETTEXT, 0, text);
            //System.Windows.Forms.SendKeys.Send(text);
            return this;
        }

        public WinApiWrapper LeftMouseClickOnTheCenterOfWindow(IntPtr hwnd) =>
            LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd,
                new POINT(
                    GetWindowWidth(hwnd) / 2,
                    GetWindowHeight(hwnd) / 2));

        public WinApiWrapper LeftMouseClickRelatedToTopLeftCornerOfWindow(IntPtr hwnd, POINT p) =>
            LeftMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowLeftX(hwnd) + p.X,
                    GetWindowTopY(hwnd) + p.Y));

        public WinApiWrapper LeftMouseClickRelatedToTopLeftCornerOfScreen(POINT p) =>
            LeftMouseClick(p.X, p.Y);

        public WinApiWrapper LeftMouseClick(int x, int y) =>
            MouseClick(x, y, MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);

        public WinApiWrapper LeftMouseClickRelatedToBottomRightCornerOfWindow(IntPtr hwnd, POINT p) =>
            LeftMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowRightX(hwnd) + p.X,
                    GetWindowBottomY(hwnd) + p.Y));

        public WinApiWrapper LeftMouseClickRelatedToBottomLeftCornerOfWindow(IntPtr hwnd, POINT p) =>
            LeftMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowLeftX(hwnd) + p.X,
                    GetWindowBottomY(hwnd) + p.Y));

        public WinApiWrapper LeftMouseClickRelatedToTopRightCornerOfWindow(IntPtr hwnd, POINT p) =>
            LeftMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowRightX(hwnd) + p.X,
                    GetWindowTopY(hwnd) + p.Y));

        public WinApiWrapper RightMouseClickRelatedToTopRightCornerOfWindow(IntPtr hwnd, POINT p) =>
            RightMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowRightX(hwnd) + p.X,
                    GetWindowTopY(hwnd) + p.Y));

        public WinApiWrapper RightMouseClickRelatedToTopLeftCornerOfWindow(IntPtr hwnd, POINT p) =>
            RightMouseClickRelatedToTopLeftCornerOfScreen(
                new POINT(
                    GetWindowLeftX(hwnd) + p.X,
                    GetWindowTopY(hwnd) + p.Y));

        //public WinApiWrapper RightMouseClickRelatedToTopRightCornerOfScreen(POINT p) =>
        //   RightMouseClick(p.X, p.Y);

        public WinApiWrapper RightMouseClickRelatedToTopLeftCornerOfScreen(POINT p) =>
            RightMouseClick(p.X, p.Y);

        public WinApiWrapper RightMouseClick(int x, int y) =>
            MouseClick(x, y, MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP);

        public int GetWindowBottomY(IntPtr hwnd) => GetWindowRect(hwnd).Bottom;
        public int GetWindowTopY(IntPtr hwnd) => GetWindowRect(hwnd).Top;
        public int GetWindowLeftX(IntPtr hwnd) => GetWindowRect(hwnd).Left;
        public int GetWindowRightX(IntPtr hwnd) => GetWindowRect(hwnd).Right;

        public int GetWindowWidth(IntPtr hwnd) => GetWindowRightX(hwnd) - GetWindowLeftX(hwnd);
        public int GetWindowHeight(IntPtr hwnd) => GetWindowBottomY(hwnd) - GetWindowTopY(hwnd);

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

        private WinApiWrapper MouseClick(int x, int y, uint down, uint up)
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

        private Rect GetWindowRect(IntPtr hwnd)
        {
            var rect = new WinApi.Rect();
            WinApi.GetWindowRect(hwnd, ref rect);
            return rect;
        }

        #endregion 
    }
}
