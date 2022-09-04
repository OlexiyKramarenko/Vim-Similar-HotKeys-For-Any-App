using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
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


        protected override void SendKeys(Window window) => actions
            .MovePointer(window.FromBottomRight(-13, -300))
            .Wait(100)
            .MouseWheel(500);

    }
}


