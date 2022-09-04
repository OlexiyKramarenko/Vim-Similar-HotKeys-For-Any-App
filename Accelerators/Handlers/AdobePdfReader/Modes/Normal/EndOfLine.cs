using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class EndOfLine : HandlerBase
    {

        public EndOfLine() { }
        public EndOfLine(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey._8_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_END);
    }
}


