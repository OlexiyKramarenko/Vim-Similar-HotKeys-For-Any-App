using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class CloseTab : HandlerBase
    {

        public CloseTab() { }
        public CloseTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.VK_OEM_4  // "["
        };


        protected override void SendKeys(WindowGeometry window) => Actions
             .Wait(350)
             .Press(VirtualKey.VK_CONTROL, VirtualKey.W_key);

    }
}


