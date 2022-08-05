using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    public class ChromeProcessor : Processor
    {
        private readonly KeysUtils u;

        public ChromeProcessor(KeysUtils utils)
        {
            u = utils;
        }

        public void Process(IntPtr hwnd)
        {
            if (u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_HOME);
            }
            ////Action<VirtualKeyStates> a =
            //    (VirtualKeyStates p) => u.SendKey(p);

            //var di = new Dictionary<string, bool>()
            //{
            //    { "Shift_G", u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL) },
            //    { "", u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL) },
            //    { "", u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL) },
            //    { "", u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL) },
            //};

            //var args = new Dictionary<string, List<Action>>
            //{
            //    {
            //        "Shift_G",
            //        new List<Action>
            //        {
            //            () => u.SendKey(VirtualKeyStates.VK_END)
            //        }
            //    },
            //    {
            //        "Shift_G",
            //        new List<Action>
            //        {
            //            () => u.SendKey(VirtualKeyStates.VK_END),
            //            () => u.SendKey(VirtualKeyStates.VK_END),
            //            () => u.SendKey(VirtualKeyStates.VK_END),
            //            () => u.SendKey(VirtualKeyStates.VK_END),
            //            () => u.SendKey(VirtualKeyStates.VK_END),
            //        }
            //    },
            //};

            //di.Where(a => a.Value)
            //  .Select(a => args[a.Key])
            //  .First()
            //  .ForEach(a => a.Invoke());




            //Shift_G
            if (u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_SHIFT))
            {
                u.SendKey(VirtualKeyStates.VK_END);
            }

            //Alt_I
            if (u.KeyIsPressed(VirtualKeyStates.I_key) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.P_key);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            if (u.KeyIsPressed(VirtualKeyStates.K_key) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeyIsPressed(VirtualKeyStates.J_key) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeyIsPressed(VirtualKeyStates.A_key) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_F4);
                u.SendKeyUp(VirtualKeyStates.VK_MENU);
            }

            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_4) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.W_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeyIsPressed(VirtualKeyStates.E_key) && u.KeyIsPressed(VirtualKeyStates.R_key) && u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.T_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeyIsPressed(VirtualKeyStates.W_key) && u.KeyIsPressed(VirtualKeyStates.G_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.H_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

            if (u.KeysArePressed(
                VirtualKeyStates.U_key,
                VirtualKeyStates.N_key,
                VirtualKeyStates.VK_CONTROL))
            {
                u.SendKey(VirtualKeyStates.VK_ESCAPE);
                u.SendKey(VirtualKeyStates.VK_TAB);
                u.SendKey(VirtualKeyStates.VK_MENU);
                u.SendKey(VirtualKeyStates.VK_RETURN);
                u.SendKey(VirtualKeyStates.L_key);
                u.SendKey(VirtualKeyStates.E_key);
            }

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

            //Alt + [
            if (u.KeyIsPressed(VirtualKeyStates.VK_OEM_1) &&
                u.KeyIsPressed(VirtualKeyStates.VK_MENU))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKeyDown(VirtualKeyStates.VK_SHIFT);
                u.SendKey(VirtualKeyStates.C_key);
                u.SendKeyUp(VirtualKeyStates.VK_SHIFT);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

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


            if (u.KeyIsPressed(VirtualKeyStates.H_key) && u.KeyIsPressed(VirtualKeyStates.B_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.D_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }


            if (u.KeyIsPressed(VirtualKeyStates.F_key) && u.KeyIsPressed(VirtualKeyStates.A_key) && u.KeyIsPressed(VirtualKeyStates.VK_CONTROL))
            {
                u.SendKeyDown(VirtualKeyStates.VK_CONTROL);
                u.SendKey(VirtualKeyStates.T_key);
                u.SendKeyUp(VirtualKeyStates.VK_CONTROL);
            }

        }
    }
}
