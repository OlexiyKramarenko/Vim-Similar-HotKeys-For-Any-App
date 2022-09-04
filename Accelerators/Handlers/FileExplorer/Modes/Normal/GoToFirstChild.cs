using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToFirstChild : HandlerBase
    {

        public GoToFirstChild() { }
        public GoToFirstChild(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.K_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_LEFT)
            .Press(VirtualKey.VK_DOWN);
    }
}


