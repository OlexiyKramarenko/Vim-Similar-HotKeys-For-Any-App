using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class ToTheBottomOfThePage : HandlerBase
    {

        public ToTheBottomOfThePage() { }
        public ToTheBottomOfThePage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-38, -75))
            .LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-40, -58));

    }
}
