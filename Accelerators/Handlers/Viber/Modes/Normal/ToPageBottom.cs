using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class ToPageBottom : HandlerBase
    {

        public ToPageBottom() { }
        public ToPageBottom(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .LeftClick(window.FromRightBottom(-38, -80))
            .LeftClick(window.FromRightBottom(-40, -58));

    }
}
