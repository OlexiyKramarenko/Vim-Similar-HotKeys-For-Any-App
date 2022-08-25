using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class CloseTab : HandlerBase
    {

        public CloseTab() { }
        public CloseTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.VK_OEM_4
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .Wait(100)
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .Wait(100)
             .SendKey(VirtualKey.W_key)
             .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


