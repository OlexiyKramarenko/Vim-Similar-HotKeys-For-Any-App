using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class Size : HandlerBase
    {

        public Size() { }
        public Size(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.S_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_HOME)
            .SendKey(VirtualKey.VK_SPACE)
            .SendKeyUp(VirtualKey.VK_HOME)
            .SendKey(VirtualKey.S_key);

    }
}


