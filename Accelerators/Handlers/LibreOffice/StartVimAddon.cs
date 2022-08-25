using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice
{
    public class StartVimAddon : HandlerBase
    {

        public StartVimAddon() { }
        public StartVimAddon(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_6
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.T_key)
            .SendKeyUp(VirtualKey.VK_MENU)
            .Wait(100)
            .SendKey(VirtualKey.VK_END)
            .SendKey(VirtualKey.VK_RIGHT)
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.V_key)
            .SendKeyUp(VirtualKey.VK_MENU);

    }
}


