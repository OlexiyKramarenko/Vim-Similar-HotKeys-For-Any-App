using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice
{
    public class Highlight : HandlerBase
    {

        public Highlight() { }
        public Highlight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey._0_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(755, 100))
            .Wait(100)
            .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(755, 410));

    }
}


