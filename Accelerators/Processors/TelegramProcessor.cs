using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    internal class TelegramProcessor
    {
        private readonly KeysUtils u;

        public TelegramProcessor(KeysUtils utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            if (u.KeyIsPressed(VirtualKeyStates.D_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            if (u.KeyIsPressed(VirtualKeyStates.U_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_PRIOR);
            }

            //if (u.KeyIsPressed(VirtualKeyStates.J_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            //{
            //    Thread.Sleep(200);
            //    u.SendKey(VirtualKeyStates.VK_ESCAPE);

            //    var pos = GetCursorPosition();

            //    int sx = GetSystemMetrics(SM_CXSCREEN);
            //    int sy = GetSystemMetrics(SM_CYSCREEN);
            //    Rect r = new Rect();
            //    GetWindowRect(hwnd, ref r);

            //    if (pos.X < r.Left || pos.X > r.Left + 300 || pos.Y < r.Top || pos.Y > r.Bottom)
            //    {
            //        //First chat
            //        int x = (r.Left + 130) * 65536 / sx;
            //        int y = (r.Top + 110) * 65536 / sy;
            //        for (int i = 0; i < 2; i++)
            //        {
            //            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //            Thread.Sleep(200);
            //            mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //        }
            //    }
            //    else
            //    {
            //        int x = (r.Left + 130) * 65536 / sx;
            //        int y = (pos.Y + 60) * 65536 / sy;
            //        for (int i = 0; i < 2; i++)
            //        {
            //            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //            Thread.Sleep(200);
            //            mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //        }
            //    }
            //}

            //if (u.KeyIsPressed(VirtualKeyStates.K_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            //{
            //    Thread.Sleep(200);
            //    u.SendKey(VirtualKeyStates.VK_ESCAPE);

            //    var pos = GetCursorPosition();

            //    if (pos.Y > 1030)
            //    {
            //        int sx = GetSystemMetrics(SM_CXSCREEN);
            //        int sy = GetSystemMetrics(SM_CYSCREEN);
            //        Rect r = new Rect();
            //        GetWindowRect(hwnd, ref r);

            //        int x = (r.Left + 130) * 65536 / sx;
            //        int y = (pos.Y - 60) * 65536 / sy;
            //        for (int i = 0; i < 2; i++)
            //        {
            //            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //            Thread.Sleep(250);
            //            mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //        }
            //    }
            //}
            //------------
            if (u.KeyIsPressed(VirtualKeyStates.G_key) &&
                //u.KeyIsPressed(VirtualKeyStates.VK_SHIFT) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                var pos = GetCursorPosition();

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);

                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx;

                int topY = r.Top * 65536 / sy;
                int bottomY = r.Bottom * 65536 / sy;
                int buttonY = (r.Bottom - 75) * 65536 / sy;

                int buttonX = (r.Right - 40) * 65536 / sx;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, buttonX, buttonY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, buttonX, buttonY, 0, UIntPtr.Zero);
            }

            //if (u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            //{
            //    //for (int i = 0; i < 30; i++)
            //    //{
            //    //    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 400, UIntPtr.Zero);
            //    //    Thread.Sleep(100);
            //    //}
            //}

            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                var pos = GetCursorPosition();

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);

                int leftX = r.Left * 65536 / sx;
                int rightX = (r.Right - 50) * 65536 / sx;

                int topY = (r.Top + 20) * 65536 / sy;
                int bottomY = r.Bottom * 65536 / sy;

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, topY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, topY, 0, UIntPtr.Zero);
            }

        }

    }
}
