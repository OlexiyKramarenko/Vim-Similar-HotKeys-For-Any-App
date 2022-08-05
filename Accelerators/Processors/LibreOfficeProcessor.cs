using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    public class LibreOfficeProcessor
    {
        private readonly KeysUtils u;

        public LibreOfficeProcessor(KeysUtils utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            // ]
            if (u.KeysArePressed(VirtualKeyStates.VK_OEM_6, VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.T_key);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);

                u.SendKey(VirtualKeyStates.VK_END);
                u.SendKey(VirtualKeyStates.VK_RIGHT);

                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.V_key);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            if (u.KeysArePressed(VirtualKeyStates.L_key, VirtualKeyStates.VK_CONTROL))
            { 
                u.SendKeyDown(VirtualKeyStates.VK_END);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_END);
            }

            if (u.KeysArePressed(VirtualKeyStates.H_key, VirtualKeyStates.VK_CONTROL))
            { 
                u.SendKeyDown(VirtualKeyStates.VK_HOME);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_HOME);
            }

            if (u.KeysArePressed(VirtualKeyStates.J_key, VirtualKeyStates.VK_CONTROL))
            { 
                u.SendKey(VirtualKeyStates.VK_DOWN);
            }

            if (u.KeysArePressed(VirtualKeyStates.K_key, VirtualKeyStates.VK_CONTROL))
            { 
                u.SendKey(VirtualKeyStates.VK_UP);
            }

            if (u.KeysArePressed(VirtualKeyStates.J_key, VirtualKeyStates.VK_SHIFT))
            { 
                u.SendKey(VirtualKeyStates.VK_END); 
                u.SendKey(VirtualKeyStates.VK_DELETE);
            }

            // ~
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_3))
            { 
                u.SendKey(VirtualKeyStates.A_key); 
                
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
 
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                
                u.SendKey(VirtualKeyStates.VK_ESCAPE);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
            }

            if (u.KeysArePressed(VirtualKeyStates.VK_OEM_4, VirtualKeyStates.VK_CONTROL))
            { 
               
                u.SendKey(VirtualKeyStates.VK_ESCAPE);
            }

            //if (u.KeysArePressed(VirtualKeyStates.J_key, VirtualKeyStates.VK_SHIFT))
            //{

            //}

            if (u.KeyIsPressed(VirtualKeyStates.VK_F11))
            {

            }

        }
    }
}
