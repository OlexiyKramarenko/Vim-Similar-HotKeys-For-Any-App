using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
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
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_LEFT)
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL, 
                   VirtualKey.VK_SHIFT,
                   VirtualKey.VK_RIGHT)
            .Wait(100)
            .Press(VirtualKey.VK_SHIFT, VirtualKey.VK_F10)
            .Wait(100)
            .Press(VirtualKey.VK_DOWN, times: 2)
            .Press(VirtualKey.VK_RETURN);

    }
}


