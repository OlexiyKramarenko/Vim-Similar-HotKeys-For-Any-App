using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Utils.WinApi;
using static Utils.WinApi.WinApi;

namespace Utils.Window
{
    public class WindowActions
    {

        public static IntPtr GetWindowHandle(string className)
        {
            return FindWindowA(className, null);
        }

        public WindowActions MovePointer(Point coords)
        {
            MouseMove(coords.X, coords.Y);
            return this;
        }

        public WindowActions RightClick(Point func)
        {
            MouseClick(func.X, func.Y, MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP);
            return this;
        }

        public WindowActions LeftClick(Point func)
        {
            MouseClick(func.X, func.Y, MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);
            return this;
        }

        public WindowActions MouseWheel(int distance)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, distance, UIntPtr.Zero);
            return this;
        }

        public WindowActions Press(VirtualKey key, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Press(key);
            }

            return this;
        }

        public WindowActions Press(VirtualKey key)
        {
            KeyDown(key);
            KeyUp(key);

            return this;
        }

        public WindowActions KeysCombination(VirtualKey key1, VirtualKey key2)
        {
            KeyDown(key2);
            Press(key1);
            KeyUp(key2);

            return this;
        }

        public WindowActions Press(VirtualKey key1, VirtualKey key2)
        {
            KeyDown(key1);
            Press(key2);
            KeyUp(key1);

            return this;
        }

        public WindowActions Press(VirtualKey key1, VirtualKey key2, VirtualKey key3)
        {
            KeyDown(key1);
            KeyDown(key2);
            Press(key3);
            KeyUp(key2);
            KeyUp(key1);

            return this;
        }

        public WindowActions SetWindowPos(IntPtr hwnd, Point topLeftAppWindowCorner, int width, int height)
        {
            WinApi.WinApi.SetWindowPos(hwnd, IntPtr.Zero,
                topLeftAppWindowCorner.X,
                topLeftAppWindowCorner.Y,
                topLeftAppWindowCorner.X + width,
                topLeftAppWindowCorner.Y + height,
                SetWindowPosFlags.ShowWindow);

            return this;
        }

        public WindowActions SendText(IntPtr programHandle, string text)
        {
            SendMessageW(programHandle, WM_SETTEXT, 0, text);
            //System.Windows.Forms.SendKeys.Send(text);
            return this;
        }

        public bool KeyIsPressed(VirtualKey key) =>
            (WinApi.WinApi.GetAsyncKeyState((int)key) & 0x8000) != 0;

        public WindowActions Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            return this;
        }

        public static IntPtr ForegroundWindowHandle => GetForegroundWindow();

        public static IntPtr GetHandleOfForegroundProcess(string processName)
        {
            Process process = GetForegroundProcess();

            if (process is null)
            {
                return IntPtr.Zero;
            }

            if (process.ProcessName.ToLower() == processName.ToLower())
            {
                return process.MainWindowHandle;
            }

            return IntPtr.Zero;
        }

        #region Private Methods

        private WindowActions KeyDown(VirtualKey key)
        {
            WinApi.WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, UIntPtr.Zero);
            return this;
        }

        private WindowActions KeyUp(VirtualKey key)
        {
            WinApi.WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
            return this;
        }

        private void MouseMove(int x, int y)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int dx = x * 65536 / sx;
            int dy = y * 65536 / sy;
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, dwData: 0, UIntPtr.Zero);
        }

        private void MouseClick(int x, int y, uint down, uint up)
        {
            int sx = GetSystemMetrics(SM_CXSCREEN);
            int sy = GetSystemMetrics(SM_CYSCREEN);
            int dx = x * 65536 / sx;
            int dy = y * 65536 / sy;
            WinApi.WinApi.mouse_event(down | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, 0, UIntPtr.Zero);
            Thread.Sleep(400);
            WinApi.WinApi.mouse_event(up | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, dx, dy, 0, UIntPtr.Zero);
        }


        private static Process GetForegroundProcess()
        {
            uint processID;
            IntPtr hWnd = GetForegroundWindow();
            GetWindowThreadProcessId(hWnd, out processID);
            Process fgProc = Process.GetProcessById(Convert.ToInt32(processID));
            return fgProc;
        }

        #endregion

    }
}
