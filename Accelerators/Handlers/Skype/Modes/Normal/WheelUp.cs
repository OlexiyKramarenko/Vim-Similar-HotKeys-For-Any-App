using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class WheelUp : HandlerBase
    {

        public WheelUp() { }
        public WheelUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_4    // "["
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .MovePointer(window.FromRightBottom(-13, -300))
            .Wait(100)
            .MouseWheel(500);

    }
}


