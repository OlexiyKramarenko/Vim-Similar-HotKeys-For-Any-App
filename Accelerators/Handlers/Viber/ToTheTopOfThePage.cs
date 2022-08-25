using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class ToTheTopOfThePage : HandlerBase
    {

        public ToTheTopOfThePage() { }
        public ToTheTopOfThePage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.G_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            winApi.MouseMoveToTopLeftCornerOfWindow(hwnd, new POINT(310, 150));

            for (int i = 0; i < 30; i++)
            {
                winApi
                  .MouseWheel(500)
                  .Wait(200);
            }
        }

    }
}
