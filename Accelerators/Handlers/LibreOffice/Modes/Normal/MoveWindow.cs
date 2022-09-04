using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
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
            .RightClick(window.FromRightTop(-200, 17))
            .Press(VirtualKey.VK_DOWN, times: 2)
            .Press(VirtualKey.VK_RETURN);

    }
}


