using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class CopyName : HandlerBase
    {

        public CopyName() { }
        public CopyName(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.W_key,
            VirtualKey.Y_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_F2)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.C_key)
            .Press(VirtualKey.VK_ESCAPE);

    }
}


