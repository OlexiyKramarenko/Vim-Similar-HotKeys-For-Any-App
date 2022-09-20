using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
{
    public class MoveLeft : HandlerBase
    {

        public MoveLeft() { }
        public MoveLeft(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.H_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_LEFT);

    }
}
