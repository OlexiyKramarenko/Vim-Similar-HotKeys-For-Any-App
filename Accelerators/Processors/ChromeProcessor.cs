using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    public class ChromeProcessor : Processor
    {
        private readonly WinApiWrapper u;

        public ChromeProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            //int PinTab__ALT_I = 0;

            // Pin tab
            // Alt_I
            if (u.KeyIsPressed(VirtualKeyStates.I_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU)
                 .Wait(300)
                 .SendKey(VirtualKeyStates.P_key)
                 .SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            //int NextTab__ALT_K = 0;

            // Next tab
            // Alt_K
            if (u.KeyIsPressed(VirtualKeyStates.K_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.Wait(100)
                 .SendKeyDown(VirtualKeyStates.VK_CONTROL)
                 .Wait(100)
                 .SendKey(VirtualKeyStates.VK_TAB)
                 .Wait(50)
                 .SendKeyUp(VirtualKeyStates.VK_CONTROL)
                 .SendKey(VirtualKeyStates.VK_ESCAPE);
            }


            // Prev tab 
            // Alt_J
            if (u.KeyIsPressed(VirtualKeyStates.J_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.Wait(100)
                 .SendKeyDown(VirtualKeyStates.VK_CONTROL)
                 .Wait(100)
                 .SendKeyDown(VirtualKeyStates.VK_SHIFT)
                 .Wait(100)
                 .SendKey(VirtualKeyStates.VK_TAB)
                 .SendKeyUp(VirtualKeyStates.VK_SHIFT)
                 .SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(100)
                 .SendKey(VirtualKeyStates.VK_ESCAPE);
            }

            // Close program
            // Alt_Q
            if (u.KeyIsPressed(VirtualKeyStates.Q_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }


            // Close all documents
            // Alt_A
            if (u.KeyIsPressed(VirtualKeyStates.A_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            // Close tab
            // Alt [
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_4) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.Wait(100).SendKeyDown(VirtualKeyStates.VK_CONTROL).Wait(100);
                u.SendKey(VirtualKeyStates.W_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Reopen closed tab 
            // Alt_R_E
            if (u.KeyIsPressed(VirtualKeyStates.E_key) &&
                u.KeyIsPressed(VirtualKeyStates.R_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            { 
                u.Wait(200)
                 .SendKey(VirtualKeyStates.VK_ESCAPE)
                 .SendKeyDown(VirtualKeyStates.VK_CONTROL)
                 .Wait(100)
                 .SendKeyDown(VirtualKeyStates.VK_SHIFT)
                 .Wait(100)
                 .SendKey(VirtualKeyStates.T_key)
                 .Wait(100)
                 .SendKeyUp(VirtualKeyStates.VK_SHIFT)
                 .SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // History 
            // Ctrl_G_W
            if (u.KeyIsPressed(VirtualKeyStates.W_key) &&
                u.KeyIsPressed(VirtualKeyStates.G_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.H_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Extensions
            // Ctrl_N_U
            if (u.KeysArePressed(
                VirtualKeyStates.U_key,
                VirtualKeyStates.N_key,
                VirtualKeyStates.VK_CONTROL))
            {
                    u.Wait(200).SendKey(VirtualKeyStates.VK_ESCAPE).Wait(100);
                u.SendKey(VirtualKeyStates.VK_TAB).Wait(100);
                u.SendKey(VirtualKeyStates.VK_MENU).Wait(100);
                u.SendKey(VirtualKeyStates.VK_RETURN).Wait(100);
                u.SendKey(VirtualKeyStates.L_key).Wait(100);
                u.SendKey(VirtualKeyStates.E_key);
            }

            // Console (open/close)
            // Ctrl_M_I
            if (u.KeyIsPressed(VirtualKeyStates.I_key) &&
                u.KeyIsPressed(VirtualKeyStates.M_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.J_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Elements
            // Alt + ; or :
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_1) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL).Wait(100);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT).Wait(100);
                u.SendKey(VirtualKeyStates.C_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Bookmarks 
            // Ctrl_B_N
            if (u.KeyIsPressed(VirtualKeyStates.N_key) &&
                u.KeyIsPressed(VirtualKeyStates.B_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.O_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Create/Edit Bookmark 
            // Ctrl_B_H
            if (u.KeyIsPressed(VirtualKeyStates.H_key) &&
                u.KeyIsPressed(VirtualKeyStates.B_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.D_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Create Tab("file")
            // Ctrl_A_F
            if (u.KeyIsPressed(VirtualKeyStates.F_key) &&
                u.KeyIsPressed(VirtualKeyStates.A_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.T_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

        }
    }
}
