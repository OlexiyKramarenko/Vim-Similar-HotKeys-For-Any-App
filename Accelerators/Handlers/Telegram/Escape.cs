using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class Escape : HandlerBase
    {

        public Escape() { }
        public Escape(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.R_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .MouseMoveToTopLeftCornerOfWindow(hwnd, new POINT(0, 200));

    }
}


