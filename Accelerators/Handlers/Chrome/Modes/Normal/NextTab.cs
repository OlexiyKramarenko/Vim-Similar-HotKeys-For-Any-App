using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class NextTab : HandlerBase
    {

        public NextTab() { }
        public NextTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.K_key
        };


        protected override void SendKeys(Window window) => actions
             .Wait(200)
             .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_TAB)
             .Press(VirtualKey.VK_ESCAPE);

    }
}


