using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class NextTab : HandlerBase
    {

        public NextTab() { }
        public NextTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.K_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .Wait(100)
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .Wait(100)
             .SendKey(VirtualKey.VK_TAB)
             .Wait(50)
             .SendKeyUp(VirtualKey.VK_CONTROL)
             .SendKey(VirtualKey.VK_ESCAPE);

    }
}


