using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class ToTheTopOfPage : HandlerBase
    {

        public ToTheTopOfPage() { }
        public ToTheTopOfPage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.G_key,
            VirtualKey.G_key
        };


        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_PRIOR);

    }
}


