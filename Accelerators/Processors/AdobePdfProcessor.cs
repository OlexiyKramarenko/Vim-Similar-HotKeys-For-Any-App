using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    internal class AdobePdfProcessor : Processor
    {
        private readonly KeysUtils u;

        public AdobePdfProcessor(KeysUtils utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {
                u.SendKey(VirtualKeyStates.VK_LEFT);
            }

            if (u.KeyIsPressed(VirtualKeyStates.J_key))
            {
                u.SendKey(VirtualKeyStates.VK_DOWN);
            }

            if (u.KeyIsPressed(VirtualKeyStates.K_key))
            {
                u.SendKey(VirtualKeyStates.VK_UP);
            }

            if (u.KeyIsPressed(VirtualKeyStates.L_key))
            {
                u.SendKey(VirtualKeyStates.VK_RIGHT);
            }

            if (u.KeyIsPressed(VirtualKeyStates.U_key))
            {
                u.SendKey(VirtualKeyStates.VK_PRIOR);
            }

            if (u.KeyIsPressed(VirtualKeyStates.D_key))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            if (u.KeyIsPressed(VirtualKeyStates._5_key))
            {
                u.SendKey(VirtualKeyStates.VK_HOME);
            }

            if (u.KeyIsPressed(VirtualKeyStates._8_key))
            {
                u.SendKey(VirtualKeyStates.VK_END);
            }


            if (u.KeyIsPressed(VirtualKeyStates.K_key) && u.KeyIsPressed(VirtualKeyStates.J_key))
            {
                u.SendKey(VirtualKeyStates.VK_ESCAPE);
            }

            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_6))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);

                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);

                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);

                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_4))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);

                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);

                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);

                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            u.OnKeyPressedTwice(
                onKey: VirtualKeyStates.G_key,
                action: u.SendKey,
                virtualKey: VirtualKeyStates.VK_PRIOR);


            if (u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_NEXT);
                u.SendKey(VirtualKeyStates.VK_NEXT);
            }

            if (u.KeyIsPressed(VirtualKeyStates.W_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_RIGHT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeyIsPressed(VirtualKeyStates.B_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_LEFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            // Note
            if (u.KeyIsPressed(VirtualKeyStates.O_key))
            {
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_F10);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_DOWN);
                u.SendKey(VirtualKeyStates.VK_RETURN);
            }

            //if (u.KeyIsPressed(VirtualKeyStates.VK_ESCAPE))
            //{
            //    //u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
            //    //u.SendKey(VirtualKeyStates.VK_UP);
            //    //u.SendKey(VirtualKeyStates.VK_DOWN); 
            //    //mouse_event(MOUSEEVENTF_LEFTDOWN, 400, 400, 0, UIntPtr.Zero);
            //    //mouse_event(MOUSEEVENTF_LEFTUP, 400, 400, 0, UIntPtr.Zero);
            //}

            ////if (u.KeyIsPressed(VirtualKeyStates.H_key) && u.KeyIsPressed(VirtualKeyStates.V_key))
            ////{
            ////    u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
            ////    u.SendKey(VirtualKeyStates.VK_LEFT);
            ////    //u.SendKeyUp(VirtualKeyStates.VK_SHIFT); 
            //}

            //if (u.KeyIsPressed(VirtualKeyStates._1_key))
            //{
            //    //SendKey(VirtualKeyStates.VK_END);
            //}

        }

    }

}
