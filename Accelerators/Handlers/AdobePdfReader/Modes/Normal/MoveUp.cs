using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class MoveUp : HandlerBase
    {

        public MoveUp() { }
        public MoveUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.K_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Wait(100)
           .Press(VirtualKey.VK_UP);

    }
}
