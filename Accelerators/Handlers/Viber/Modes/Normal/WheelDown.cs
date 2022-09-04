using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class WheelDown : HandlerBase
    {

        public WheelDown() { }
        public WheelDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_6  // "]"
        };


        protected override void SendKeys(Window window) => actions
            .LeftClick(window.FromTopLeft(310, 300))
            .MouseWheel(-400);

    }
}


