using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class Extensions : HandlerBase
    {

        public Extensions() { }
        public Extensions(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.N_key,
            VirtualKey.U_key
        };


        protected override void SendKeys(Window window) => actions
            .Wait(200)
            .Press(VirtualKey.VK_ESCAPE)
            .Wait(100)
            .Press(VirtualKey.VK_TAB)
            .Wait(100)
            .Press(VirtualKey.VK_MENU)
            .Wait(100)
            .Press(VirtualKey.VK_RETURN)
            .Wait(100)
            .Press(VirtualKey.L_key)
            .Wait(100)
            .Press(VirtualKey.E_key);

    }
}


