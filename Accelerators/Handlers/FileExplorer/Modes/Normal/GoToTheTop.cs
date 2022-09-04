using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToTheTop : HandlerBase
    {

        public GoToTheTop() { }
        public GoToTheTop(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.G_key,
            VirtualKey.G_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_PRIOR);
    }
}


