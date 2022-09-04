using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class Move : HandlerBase
    {

        public Move() { }
        public Move(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.M_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_SPACE)
            .Press(VirtualKey.M_key);
    }
}


