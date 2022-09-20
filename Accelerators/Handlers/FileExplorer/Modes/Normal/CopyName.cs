using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
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


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_F2)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.C_key)
            .Press(VirtualKey.VK_ESCAPE);

    }
}


