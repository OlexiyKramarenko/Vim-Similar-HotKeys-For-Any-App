using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class WheelUp : HandlerBase
    {

        public WheelUp() { }
        public WheelUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_4  // "["
        };


        protected override void SendKeys(Window window) => actions
           .LeftClick(window.FromTopLeft(310, 300))
           .MouseWheel(400);

    }
}


