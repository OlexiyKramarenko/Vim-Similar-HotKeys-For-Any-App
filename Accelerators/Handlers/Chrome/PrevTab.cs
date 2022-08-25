using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class PrevTab : HandlerBase
    {

        public PrevTab() { }
        public PrevTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.J_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .Wait(100)
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .Wait(100)
             .SendKeyDown(VirtualKey.VK_SHIFT)
             .Wait(100)
             .SendKey(VirtualKey.VK_TAB)
             .SendKeyUp(VirtualKey.VK_SHIFT)
             .SendKeyUp(VirtualKey.VK_CONTROL).Wait(100)
             .SendKey(VirtualKey.VK_ESCAPE);

    }
}


