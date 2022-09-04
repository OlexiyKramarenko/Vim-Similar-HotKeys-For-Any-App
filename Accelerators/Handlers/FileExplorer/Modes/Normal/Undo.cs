using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

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


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.Z_key);

    }
}


