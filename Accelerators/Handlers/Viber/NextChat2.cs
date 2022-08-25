using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class NextChat2 : HandlerBase
    {

        public NextChat2() { }
        public NextChat2(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.J_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            var yPos = winApi.GetCursorWindowPositionFromTopLeftCornerOfWindow(hwnd).Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel)
            {
                winApi.LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, 168)); // Click on the first chat
            }
            else if (yPos < winApi.GetWindowHeight(hwnd) - 140)
            {
                winApi
                    .Wait(100)
                    .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, yPos + 65)); // Click on the next chat
            }
            else
            {
                winApi
                .Wait(50)
                .MouseWheel(-55)
                .Wait(50)
                .MouseWheel(-55)
                .Wait(50)
                .LeftMouseClickRelatedToBottomLeftCornerOfWindow(hwnd, new POINT(x, -50)); // Click on the last chat
            }
        }

    }
}


