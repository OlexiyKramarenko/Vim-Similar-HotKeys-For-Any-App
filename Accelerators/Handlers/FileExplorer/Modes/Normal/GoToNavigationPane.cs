using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToNavigationPane : HandlerBase
    {

        public GoToNavigationPane() { }
        public GoToNavigationPane(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_1  // ";"
        };


        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL,VirtualKey.F_key)
            .Wait(50) 
            .Press(VirtualKey.VK_TAB);
    }
}
