using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
{
    public class Highlight : HandlerBase
    {

        public Highlight() { }
        public Highlight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_4 // "["
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .LeftClick(window.FromLeftTop(755, 100))
            .Wait(100)
            .LeftClick(window.FromLeftTop(755, 410));

    }
}


