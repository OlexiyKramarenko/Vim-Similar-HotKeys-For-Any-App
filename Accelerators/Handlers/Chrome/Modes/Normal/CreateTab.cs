using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class CreateTab : HandlerBase
    {

        public CreateTab() { }
        public CreateTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.A_key,
            VirtualKey.F_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.T_key);

    }
}


