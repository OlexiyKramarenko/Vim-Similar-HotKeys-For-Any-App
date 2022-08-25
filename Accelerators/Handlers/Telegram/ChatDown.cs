using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class ChatDown : HandlerBase
    {

        public ChatDown() { }
        public ChatDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.K_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_TAB)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


