using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class PrevTab : HandlerBase
    {

        public PrevTab() { }
        public PrevTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.J_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
             .Wait(200)
             .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_SHIFT, VirtualKey.VK_TAB)
             .Press(VirtualKey.VK_ESCAPE);

    }
}


