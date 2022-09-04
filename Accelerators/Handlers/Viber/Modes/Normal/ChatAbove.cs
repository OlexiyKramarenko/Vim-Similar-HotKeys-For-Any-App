using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class ChatAbove : HandlerBase
    {

        public ChatAbove() { }
        public ChatAbove(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.K_key
        };


        protected override void SendKeys(WindowGeometry window)
        {
            var yPos = window.FromTopLeft.Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel + 86)
            {
                Actions
                    .Wait(50)
                    .MouseWheel(75)
                    .Wait(50)
                    .MouseWheel(75)
                    .Wait(50)
                    .LeftClick(window.FromLeftTop(x, 200));
            }
            else if (yPos < window.Height - 90)
            {
                Actions
                    .Wait(100)
                    .LeftClick(window.FromLeftTop(x, yPos - 65)); // Click on the next chat
            }
            else
            {
                // Click on the last chat
                Actions
                  .LeftClick(window.FromLeftBottom(x, -100))
                  .MouseWheel(90)
                  .MovePointer(window.FromLeftBottom(x, -100));
            }
        }

    }
}


