using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class PinTab : HandlerBase
    {

        public PinTab() { }
        public PinTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.I_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_MENU)
            .Wait(300)
            .SendKey(VirtualKey.P_key)
            .SendKeyUp(VirtualKey.VK_MENU);

    }
}


