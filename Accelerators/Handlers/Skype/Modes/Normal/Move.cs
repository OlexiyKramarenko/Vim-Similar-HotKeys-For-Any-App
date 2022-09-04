using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class Move : HandlerBase
    {

        public Move() { }
        public Move(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.M_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .RightClick(window.FromRightTop(-200, 20))
            .Wait(100)
            .Press(VirtualKey.VK_DOWN, times: 2)
            .Press(VirtualKey.VK_RETURN);

    }
}


