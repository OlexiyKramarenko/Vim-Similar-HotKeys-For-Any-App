using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class PrevChat : HandlerBase
    {

        public PrevChat() { }
        public PrevChat(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.K_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            var yPos = winApi.GetCursorWindowPositionFromTopLeftCornerOfWindow(hwnd).Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel + 86)
            {
                winApi.Wait(50)
                      .MouseWheel(75)
                      .Wait(50)
                      .MouseWheel(75)
                      .Wait(50)
                      .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, 200));
            }
            else if (yPos < winApi.GetWindowHeight(hwnd) - 90)
            {
                winApi.Wait(100)
                      .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(x, yPos - 65)); // Click on the next chat
            }
            else
            {
                // Click on the last chat
                winApi
                  .LeftMouseClickRelatedToBottomLeftCornerOfWindow(hwnd, new POINT(x, -100))
                  .MouseWheel(90)
                  .MouseMoveToBottomLeftCornerOfWindow(hwnd, new POINT(x, -100));
            }
        }

    }
}


