using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class StartOfLine : HandlerBase
    {

        public StartOfLine() { }
        public StartOfLine(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey._5_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Press(VirtualKey.VK_HOME);

    }
}
