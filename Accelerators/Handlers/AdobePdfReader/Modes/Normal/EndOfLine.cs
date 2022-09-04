using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_END);
    }
}


