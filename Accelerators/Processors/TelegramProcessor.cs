using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    internal class TelegramProcessor
    {
        private readonly WinApiWrapper u;

        public TelegramProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            // Exit
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.VK_F4))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            // Up
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.D_key))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            // Down
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.U_key))
            {
                u.SendKey(VirtualKeyStates.VK_PRIOR);
            }

            // Chat Up 
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.J_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Chat Down 
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.K_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.R_key))
            {
                u.MouseMoveToTopLeftCornerOfWindow(hwnd, new POINT(0, 200));
            }

            // Page Top
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.G_key))
            {
                u.MouseWheel(300);
            }

            // Page Bottom
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_SHIFT, VirtualKeyStates.G_key))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-50, -100));
            }

            // Window Size
            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-70, -15));
            }

            // Minimize
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.N_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_HOME);
                u.SendKey(VirtualKeyStates.VK_SPACE);
                u.SendKeyUp(VirtualKeyStates.VK_HOME);

                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // Minimize
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.N_key))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(125, 15));
            }

            // Size
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.S_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_HOME);
                u.SendKey(VirtualKeyStates.VK_SPACE);
                u.SendKeyUp(VirtualKeyStates.VK_HOME); 
                u.SendKey(VirtualKeyStates.S_key);
            }

            // Move
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.M_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_HOME);
                u.SendKey(VirtualKeyStates.VK_SPACE);
                u.SendKeyUp(VirtualKeyStates.VK_HOME); 
                u.SendKey(VirtualKeyStates.M_key);
            }

        }
    }
}
