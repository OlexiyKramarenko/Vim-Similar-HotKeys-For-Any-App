using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class EndOfTheWord : HandlerBase
    {

        public EndOfTheWord() { }
        public EndOfTheWord(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.E_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Wait(100)
           .Press(VirtualKey.VK_RIGHT)
           .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_RIGHT)
           .Press(VirtualKey.VK_LEFT);

    }
}


