using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class Maximize : HandlerBase
    {

        public Maximize() { }
        public Maximize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_F11
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .LeftClick(window.FromRightTop(-76, 3));

    }
}
