using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    internal class AdobePdfProcessor : Processor
    {
        private readonly WinApiWrapper u;
        private readonly TwiceKeyPressHandler _keyPressHandler;

        public AdobePdfProcessor(WinApiWrapper utils, TwiceKeyPressHandler keyPressHandler)
        {
            u = utils;
            _keyPressHandler = keyPressHandler;
        }

        public void Process(IntPtr hwnd)
        {
            // Left
            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {
                u.SendKey(VirtualKeyStates.VK_LEFT);
            }

            // Down
            if (u.KeyIsPressed(VirtualKeyStates.J_key))
            {
                u.SendKey(VirtualKeyStates.VK_DOWN);
            }

            // Up
            if (u.KeyIsPressed(VirtualKeyStates.K_key))
            {
                u.SendKey(VirtualKeyStates.VK_UP);
            }

            // Right
            if (u.KeyIsPressed(VirtualKeyStates.L_key))
            {
                u.SendKey(VirtualKeyStates.VK_RIGHT);
            }

            // Page Up
            if (u.KeyIsPressed(VirtualKeyStates.U_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_PRIOR);
            }

            // Page Down
            if (u.KeyIsPressed(VirtualKeyStates.D_key))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            // Start of the line
            if (u.KeyIsPressed(VirtualKeyStates._4_key))
            {
                u.SendKey(VirtualKeyStates.VK_HOME);
            }

            // End of the line
            if (u.KeyIsPressed(VirtualKeyStates._8_key))
            {
                u.LeftMouseClickOnTheCenterOfWindow(hwnd);

                u.SendKey(VirtualKeyStates.VK_END);
            }

            // Esc
            if (u.KeyIsPressed(VirtualKeyStates.K_key) &&
                u.KeyIsPressed(VirtualKeyStates.J_key))
            {
                u.LeftMouseClickOnTheCenterOfWindow(hwnd);

                u.SendKey(VirtualKeyStates.VK_ESCAPE);

            }

            // Undo
            if (u.KeyIsPressed(VirtualKeyStates.U_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.Z_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
                u.LeftMouseClickOnTheCenterOfWindow(hwnd);
            }

            // ] Add stick Note
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_6))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(100);

                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(100);

                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT).Wait(100);

                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // [ Highlight
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_4))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(100);

                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL).Wait(100);

                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT).Wait(100);

                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            // GG
            _keyPressHandler.OnKeyPressedTwice(
                onKey: VirtualKeyStates.G_key,
                func: u.SendKey,
                virtualKey: VirtualKeyStates.VK_PRIOR);

            // Ctrl + G
            if (u.KeyIsPressed(VirtualKeyStates.G_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            // E
            if (u.KeyIsPressed(VirtualKeyStates.E_key))
            {
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
            }

            // W
            if (u.KeyIsPressed(VirtualKeyStates.W_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }


            // B
            if (u.KeyIsPressed(VirtualKeyStates.B_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Open tree "o"
            if (u.KeyIsPressed(VirtualKeyStates.O_key) &&
                u.KeyIsPressed(VirtualKeyStates.VK_LSHIFT))
            {
                u.SendKey(VirtualKeyStates.VK_RIGHT);
            }

            // Close node in tree O
            if (u.KeyIsPressed(VirtualKeyStates.O_key))
            {
                u.SendKey(VirtualKeyStates.VK_LEFT);
            }

        }
    }
}
