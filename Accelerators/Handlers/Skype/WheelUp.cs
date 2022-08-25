using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class WheelUp : HandlerBase
    {

        public WheelUp() { }
        public WheelUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_4
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .MouseMoveToBottomRightCornerOfWindow(hwnd, new POINT(-13, -300))
            .Wait(100)
            .MouseWheel(500);

    }
}


