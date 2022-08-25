using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class ToPageBottom : HandlerBase
    {

        public ToPageBottom() { }
        public ToPageBottom(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-50, -100));

    }
}


