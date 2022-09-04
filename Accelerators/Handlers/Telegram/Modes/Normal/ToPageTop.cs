using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class ToPageTop : HandlerBase
    {

        public ToPageTop() { }
        public ToPageTop(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.G_key
        };


        protected override void SendKeys(Window window) => actions
            .MouseWheel(300);

    }
}


