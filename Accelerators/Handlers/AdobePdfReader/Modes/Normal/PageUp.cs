using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class PageUp : HandlerBase
    {

        public PageUp() { }
        public PageUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.U_key
        };


        protected override void SendKeys(Window window) => actions
           .Wait(100)
           .Press(VirtualKey.VK_PRIOR);

    }
}
