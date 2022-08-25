using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class Maximize : HandlerBase
    {

        public Maximize() { }
        public Maximize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_F11
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-70, -15));

    }
}


