using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class MoveRight : HandlerBase
    {

        public MoveRight() { }
        public MoveRight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.L_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_RIGHT);

    }
}
