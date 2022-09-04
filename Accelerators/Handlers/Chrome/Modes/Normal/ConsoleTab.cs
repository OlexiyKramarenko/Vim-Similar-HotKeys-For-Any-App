using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class ConsoleTab : HandlerBase
    {

        public ConsoleTab() { }
        public ConsoleTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.M_key,
            VirtualKey.I_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL,
                   VirtualKey.VK_SHIFT,
                   VirtualKey.J_key);

    }
}


