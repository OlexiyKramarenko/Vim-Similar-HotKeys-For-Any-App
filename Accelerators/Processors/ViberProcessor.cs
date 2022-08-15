using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    internal class ViberProcessor : Processor
    {
        private readonly WinApiWrapper u;

        public ViberProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {

            // Click on the first chat
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.I_key))
            {
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(80, 165));
            }

            // Exit
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.Q_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            //// Page Down
            //if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.D_key))
            //{
            //    u.Wait(100).SendKey(VirtualKeyStates.VK_ESCAPE);
            //    u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200));
            //    u.SendKey(VirtualKeyStates.VK_ESCAPE);
            //    u.SendKey(VirtualKeyStates.VK_ESCAPE);
            //    u.SendKey(VirtualKeyStates.VK_ESCAPE);
            //    u.MouseWheel(400);
            //    //u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200));
            //}

            // Page Down
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_OEM_6))
            {
                u.Wait(100);
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200));
                u.Wait(50);
                u.MouseWheel(-400);
            }

            // Page Up
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_OEM_4))
            {
                u.Wait(100);
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200));
                u.Wait(50);
                u.MouseWheel(400);
            }
            // Page Up
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.U_key))
            {
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200));
                u.MouseWheel(400);
            }

            //  Next Chat
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.J_key))
            {
                var yPos = u.GetCursorWindowPositionFromTopLeftCornerOfWindow(hwnd).Y;

                var bottom = u.GetWindowHeight(hwnd);

                var bottomOftheTopPanel = 160;

                var x = 170;

                if (yPos <= bottomOftheTopPanel)
                {
                    // Click on the first chat
                    u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, 168));
                }
                else if (yPos < u.GetWindowHeight(hwnd) - 140)
                {
                    u.Wait(100);

                    // Click on the next chat
                    u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, yPos + 65));
                }
                else
                {
                    u.Wait(50);
                    u.MouseWheel(-55);
                    u.Wait(50);
                    u.MouseWheel(-55);
                    u.Wait(50);

                    // Click on the last chat
                    u.LeftMouseClickRelatedToBottomLeftCornerOfWindow(hwnd, new POINT(x, -50));
                }
            }

            //  Prev Chat
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.K_key))
            {
                var yPos = u.GetCursorWindowPositionFromTopLeftCornerOfWindow(hwnd).Y;

                var bottom = u.GetWindowHeight(hwnd);

                var bottomOftheTopPanel = 160;

                var x = 170;

                if (yPos <= bottomOftheTopPanel + 86)
                {
                    u.Wait(50);
                    u.MouseWheel(75);
                    u.Wait(50);
                    u.MouseWheel(75);
                    u.Wait(50);

                    u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, 200));
                }
                else if (yPos < u.GetWindowHeight(hwnd) - 90)
                {
                    u.Wait(100);

                    // Click on the next chat
                    u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, yPos - 65));
                }
                else
                {
                    // Click on the last chat
                    u.LeftMouseClickRelatedToBottomLeftCornerOfWindow(hwnd, new POINT(x, -100));
                    u.MouseWheel(90);
                    u.MouseMoveToBottomLeftCornerOfWindow(hwnd, new POINT(x, -100));
                }
            }

            // Page Bottom
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_SHIFT, VirtualKeyStates.G_key))
            {
                u.LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-38, -75));
                u.LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-40, -58));
            }

            // Page Top
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.G_key))
            {
                u.MouseMoveToTopLeftCornerOfWindow(hwnd, new POINT(310, 150));
                for (int i = 0; i < 30; i++)
                {
                    u.MouseWheel(500);
                    u.Wait(200);
                }
            }

            // Change Size
            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-90, 20));
            }

            // Min
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.N_key))
            {
                //u.SendKey(VirtualKeyStates.VK_ESCAPE);
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-130, 20));
            }

            // Move
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.M_key))
            {
                u.RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-300, 20));
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // Size
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.S_key))
            {
                u.RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-300, 20));
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

        }
    }
}
