using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class Escape : HandlerBase
    {

        public Escape() { }
        public Escape(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.K_key,
            VirtualKey.J_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(300)
            .Press(VirtualKey.VK_BACK)
            .Press(VirtualKey.VK_BACK)
            .Press(VirtualKey.VK_ESCAPE);

    }
}


