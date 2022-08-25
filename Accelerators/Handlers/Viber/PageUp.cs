using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class PageUp : HandlerBase
    {

        public PageUp() { }
        public PageUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_4
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .Wait(100)
           .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200))
           .Wait(50)
           .MouseWheel(400);

    }
}


