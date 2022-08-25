using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class PageUp2 : HandlerBase
    {

        public PageUp2() { }
        public PageUp2(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.U_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(310, 200))
           .MouseWheel(400);

    }
}


