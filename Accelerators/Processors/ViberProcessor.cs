using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    internal class ViberProcessor : Processor
    {
        private readonly KeysUtils u;

        public ViberProcessor(KeysUtils utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                var pos = GetCursorPosition();

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);
                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx - 1700;
                int topY = r.Top * 65536 / sy + 200;
                //int bottomY = r.Bottom * 65536 / sy - 2000;
                int bottomY = r.Bottom * 65536 / sy - 3300;

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, topY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, topY, 0, UIntPtr.Zero);
            }

            if (u.KeyIsPressed(VirtualKeyStates.J_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                var pos = GetCursorPosition();

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);

                int cursorX = pos.X * 65536 / sx;
                int cursorY = pos.Y * 65536 / sy;


                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);
                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx;
                int topY = r.Top * 65536 / sy;
                int bottomY = r.Bottom * 65536 / sy;
                int chatX = leftX + 3200;
                if (cursorY < topY + 6100) // && cursorX < leftX + 100
                {
                    int firstChatY = topY + 6200;

                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, firstChatY, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, firstChatY, 0, UIntPtr.Zero);
                }
                else if (cursorY < bottomY - 2617)
                {
                    int firstChatY = topY + 6200;

                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, cursorY + 2000, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, cursorY + 2000, 0, UIntPtr.Zero);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -100, UIntPtr.Zero);
                }
            }

            if (u.KeyIsPressed(VirtualKeyStates.K_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                var pos = GetCursorPosition();

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);

                int cursorX = pos.X * 65536 / sx;
                int cursorY = pos.Y * 65536 / sy;


                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);
                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx;
                int topY = r.Top * 65536 / sy;
                int bottomY = r.Bottom * 65536 / sy;
                int chatX = leftX + 3200;
                if (cursorY < topY + 6100) // && cursorX < leftX + 100
                {
                    int firstChatY = topY + 5200;

                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, firstChatY, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, firstChatY, 0, UIntPtr.Zero);
                }
                else if (cursorY > topY + 9250)
                {
                    int firstChatY = topY + 6200;

                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, cursorY - 2000, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, chatX, cursorY - 2000, 0, UIntPtr.Zero);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 100, UIntPtr.Zero);
                }
            }

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
                int rightX = r.Right * 65536 / sx - 900;
                int topY = r.Top * 65536 / sy;
                //int bottomY = r.Bottom * 65536 / sy - 2000;
                int bottomY = r.Bottom * 65536 / sy - 3300;

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, bottomY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, bottomY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -500, UIntPtr.Zero);

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, bottomY + 1060, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightX, bottomY + 1060, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -500, UIntPtr.Zero);
            }

            //Next message
            if (u.KeyIsPressed(VirtualKeyStates.VK_UP) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_UP);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            //Prev message
            if (u.KeyIsPressed(VirtualKeyStates.VK_DOWN) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

//--------------------------------------
            // Click on first chat
            if (u.KeyIsPressed(VirtualKeyStates.I_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);


                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);

                int leftX = r.Left * 65536 / sx;
                int topY = r.Top * 65536 / sy;

                int firstChatY = topY + 6200;
                int firstChatX = leftX + 3200;

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, firstChatX, firstChatY, 0, UIntPtr.Zero);
                Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, firstChatX, firstChatY, 0, UIntPtr.Zero);
            }

            // Page Down
            if (u.KeyIsPressed(VirtualKeyStates.D_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);

                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx;
                int topY = r.Top * 65536 / sy;

                int firstChatY = topY + 6200;
                int firstChatX = leftX + 6500;

                //int rightScrollX = rightX - 160;
                int rightScrollX = leftX + 6600;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightScrollX, firstChatY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightScrollX, firstChatY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -500, UIntPtr.Zero);
            }

            // Page Up
            if (u.KeyIsPressed(VirtualKeyStates.U_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                Rect r = new Rect();
                GetWindowRect(hwnd, ref r);

                int sx = GetSystemMetrics(SM_CXSCREEN);
                int sy = GetSystemMetrics(SM_CYSCREEN);

                int leftX = r.Left * 65536 / sx;
                int rightX = r.Right * 65536 / sx;
                int topY = r.Top * 65536 / sy;

                int firstChatY = topY + 6200;
                int firstChatX = leftX + 6500;

                //int rightScrollX = rightX - 160; 
                int rightScrollX = leftX + 6600;

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightScrollX, firstChatY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, rightScrollX, firstChatY, 0, UIntPtr.Zero);
                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 500, UIntPtr.Zero);
            }


         

            //if (u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 500, UIntPtr.Zero);
            //        Thread.Sleep(150);
            //    }
            //}

          
        }
    }
}
