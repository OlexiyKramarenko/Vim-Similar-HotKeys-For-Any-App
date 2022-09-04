using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToParent : HandlerBase
    {

        public GoToParent() { }
        public GoToParent(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.P_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_BACK);
    }
}


