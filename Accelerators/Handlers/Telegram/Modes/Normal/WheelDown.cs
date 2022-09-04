using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class WheelDown : HandlerBase
    {

        public WheelDown() { }
        public WheelDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_6   //   "]"
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .MovePointer(window.FromRightBottom(-13, -300))
           .Wait(100)
           .MouseWheel(-500);
    }
}


