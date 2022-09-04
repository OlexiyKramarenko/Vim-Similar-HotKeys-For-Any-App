using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class ChatBelow : HandlerBase
    {

        public ChatBelow() { }
        public ChatBelow(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.K_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(200)
            .Press(VirtualKey.VK_CONTROL,
                   VirtualKey.VK_SHIFT,
                   VirtualKey.VK_TAB);

    }
}


