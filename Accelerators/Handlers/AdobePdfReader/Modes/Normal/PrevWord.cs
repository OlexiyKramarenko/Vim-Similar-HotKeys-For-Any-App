using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class PrevWord : HandlerBase
    {

        public PrevWord() { }
        public PrevWord(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.B_key
        };


        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_LEFT);

    }
}


