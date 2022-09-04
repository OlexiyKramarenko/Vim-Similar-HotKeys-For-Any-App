using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class AddDirectory : HandlerBase
    {

        public AddDirectory() { }
        public AddDirectory(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.A_key,
            VirtualKey.D_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_SHIFT, VirtualKey.N_key)
            .Press(VirtualKey.VK_F5);

    }
}


