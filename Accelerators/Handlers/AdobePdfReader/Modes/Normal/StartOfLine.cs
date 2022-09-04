using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window) => actions
           .Press(VirtualKey.VK_HOME);

    }
}
