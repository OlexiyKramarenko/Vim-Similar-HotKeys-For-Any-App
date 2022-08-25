using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram
{
    public class Minimize : HandlerBase
    {

        public Minimize() { }
        public Minimize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.N_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_HOME)
            .SendKey(VirtualKey.VK_SPACE)
            .SendKeyUp(VirtualKey.VK_HOME)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_RETURN);

    }
}


