using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
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
            .RightClick(window.FromRightTop(-200, 20))
            .Wait(100)
            .Press(VirtualKey.VK_DOWN, times: 3)
            .Press(VirtualKey.VK_RETURN);

    }
}


