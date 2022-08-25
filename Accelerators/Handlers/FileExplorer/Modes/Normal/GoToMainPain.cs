using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToMainPane : HandlerBase
    {

        public GoToMainPane() { }
        public GoToMainPane(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.VK_OEM_1  // ";"
        };


        protected override void SendKeys(IntPtr hwndParent, WinApiWrapper winApi) => winApi
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.F_key)
            .SendKeyUp(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.VK_TAB)
            .SendKey(VirtualKey.VK_TAB);

    }
}
