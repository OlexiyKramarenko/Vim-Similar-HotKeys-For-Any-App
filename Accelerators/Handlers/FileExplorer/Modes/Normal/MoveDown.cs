using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class MoveDown : HandlerBase
    {

        public MoveDown() { }
        public MoveDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.J_key
        };


        protected override void SendKeys(Window window) => actions
           .Wait(150)
           .Press(VirtualKey.VK_DOWN);

    }
}
