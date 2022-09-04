using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class MoveDown : HandlerBase
    {

        public MoveDown() { }
        public MoveDown(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.J_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Wait(100)
           .Press(VirtualKey.VK_DOWN);

    }
}
