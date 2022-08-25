using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class Minimize : HandlerBase
    {

        public Minimize() { }
        public Minimize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.N_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.VK_SPACE)
            .SendKeyUp(VirtualKey.VK_MENU)
            .Wait(100)
            .SendKey(VirtualKey.N_key);

    }
}


