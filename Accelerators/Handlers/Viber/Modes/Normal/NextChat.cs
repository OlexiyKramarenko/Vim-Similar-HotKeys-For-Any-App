using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class NextChat : HandlerBase
    {

        public NextChat() { }
        public NextChat(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.J_key
        };


        protected override void SendKeys(WindowGeometry window)
        {
            var yPos = window.FromTopLeft.Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel)
            {
                Actions.LeftClick(window.FromLeftTop(x, 168)); // Click on the first chat 
            }
            else if (yPos < window.Height - 140)
            {
                Actions
                    .Wait(100)
                    .LeftClick(window.FromLeftTop(x, yPos + 65)); // Click on the next chat
            }
            else
            {
                Actions
                    .Wait(50)
                    .MouseWheel(-55)
                    .Wait(50)
                    .MouseWheel(-55)
                    .Wait(50)
                    .LeftClick(window.FromLeftBottom(x, -50)); // Click on the last chat
            }
        }

    }
}


