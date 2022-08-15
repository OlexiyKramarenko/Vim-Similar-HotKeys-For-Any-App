using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    public class SkypeProcessor : Processor
    {
        private readonly WinApiWrapper u;

        public SkypeProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            // Exit
            if (u.KeysArePressed(VirtualKeyStates.Q_key, VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            // Chat Down
            if (u.KeysArePressed(VirtualKeyStates.J_key, VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Chat Up
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.K_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Wheel Up 
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_OEM_4))
            {
                u.MouseMoveToBottomRightCornerOfWindow(hwnd, new POINT(-13, -300));
                u.Wait(100);
                u.MouseWheel(500);
            }

            // Wheel Down 
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_OEM_6))
            {
                u.MouseMoveToBottomRightCornerOfWindow(hwnd, new POINT(-13, -300));
                u.Wait(100);
                u.MouseWheel(-500);
            }

            // To the bottom
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_SHIFT, VirtualKeyStates.G_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.G_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(200);
                u.LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-50, -110));
                u.LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-50, -110));
            }

            // Edit Last Message
            if (u.KeysArePressed(VirtualKeyStates.VK_CONTROL, VirtualKeyStates.VK_UP))
            {
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);

                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);

                u.SendKey(VirtualKeyStates.VK_UP);
            }

            // F11 (window size)
            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-76, 3));
            }

            // Min
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.N_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_SPACE);
                u.SendKeyUp(VirtualKeyStates.VK_MENU).Wait(100);
                u.SendKey(VirtualKeyStates.N_key);
            }

            // Size
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.S_key))
            {
                u.RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-200, 20));
                u.Wait(100).SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // Move
            if (u.KeysArePressed(VirtualKeyStates.VK_MENU, VirtualKeyStates.M_key))
            {
                u.RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-200, 20));
                u.Wait(100).SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // Hidden Recent Chats

            // Contacts 

        }
    }
}
