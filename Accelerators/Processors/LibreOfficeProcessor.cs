using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    public class LibreOfficeProcessor
    {
        private readonly WinApiWrapper u;

        public LibreOfficeProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            // Start Vim add-on 
            // Ctrl _ ]
            if (u.KeysArePressed(VirtualKeyStates.VK_OEM_6, VirtualKeyStates.VK_CONTROL))
            {
                u.Wait(100).SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.T_key);
                u.SendKeyUp(VirtualKeyStates.VK_MENU).Wait(100);

                u.SendKey(VirtualKeyStates.VK_END);
                u.SendKey(VirtualKeyStates.VK_RIGHT)
                    .Wait(100);

                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.V_key);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            // Remove spaces
            if (u.KeysArePressed(VirtualKeyStates.J_key, VirtualKeyStates.VK_SHIFT))
            {
                u.Wait(200).SendKey(VirtualKeyStates.VK_END).Wait(100);
                u.SendKey(VirtualKeyStates.VK_DELETE);
            }

            // ~   Tools -> Customize -> Format -> Toggle case
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_3))
            {
                u.Wait(100).SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT).Wait(100);
            }

            // Ctrl + 0 Highlight (Yellow)
            if (u.KeysArePressed(VirtualKeyStates._0_key, VirtualKeyStates.VK_CONTROL))
            {
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(755, 100)).Wait(100);
                u.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(755, 410));
            }

            // Change window size
            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-76, 17));
            }

            // Move window
            if (u.KeysArePressed(VirtualKeyStates.N_key, VirtualKeyStates.VK_MENU))
            {
                u.RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-200, 17));
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // Minimize
            if (u.KeysArePressed(VirtualKeyStates.N_key, VirtualKeyStates.VK_MENU))
            {
                u.LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-130, 17));
            }
        }
    }
}
