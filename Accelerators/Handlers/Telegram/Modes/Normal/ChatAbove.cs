using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class ChatAbove : HandlerBase
    {

        public ChatAbove() { }
        public ChatAbove(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.J_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(200)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_TAB);

    }
}


