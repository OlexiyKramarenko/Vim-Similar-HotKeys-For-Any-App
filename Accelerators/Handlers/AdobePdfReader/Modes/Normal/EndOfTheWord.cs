using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window) => actions
           .Wait(100)
           .Press(VirtualKey.VK_RIGHT)
           .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_RIGHT)
           .Press(VirtualKey.VK_LEFT);

    }
}


