using Utils.Window;
using Utils.WinApi;

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


        protected override void SendKeys(WindowGeometry window) => Actions
            .MouseWheel(300);

    }
}


