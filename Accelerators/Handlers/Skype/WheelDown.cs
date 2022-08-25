using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class WheelDown : HandlerBase
    {

        public WheelDown() { }
        public WheelDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_6
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .MouseMoveToBottomRightCornerOfWindow(hwnd, new POINT(-13, -300))
            .Wait(100)
            .MouseWheel(-500);

    }
}


