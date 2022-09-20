using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.VisualStudio.Modes.Normal
{
    public class Size : HandlerBase
    {

        public Size() { }
        public Size(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.S_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_SPACE)
            .Press(VirtualKey.VK_DOWN, times: 2)
            .Press(VirtualKey.VK_RETURN);

    }
}


