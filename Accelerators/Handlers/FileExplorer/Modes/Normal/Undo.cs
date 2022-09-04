using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class Undo : HandlerBase
    {

        public Undo() { }
        public Undo(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.U_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.Z_key);

    }
}


