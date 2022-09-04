using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class ReopenClosedTab : HandlerBase
    {

        public ReopenClosedTab() { }
        public ReopenClosedTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.R_key,
            VirtualKey.E_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
             .Wait(200)
             .Press(VirtualKey.VK_ESCAPE)
             .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_SHIFT, VirtualKey.T_key);

    }
}


