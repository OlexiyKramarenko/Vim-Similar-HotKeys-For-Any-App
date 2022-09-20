using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.VisualStudio.Modes.Normal
{
    public class MoveWindow : HandlerBase
    {

        public MoveWindow() { }
        public MoveWindow(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.M_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_SPACE)
            .Press(VirtualKey.M_key);
    }
}


