using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window)
        {
            var yPos = window.FromTopLeft().Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel + 86)
            {
                actions
                    .Wait(50)
                    .MouseWheel(75)
                    .Wait(50)
                    .MouseWheel(75)
                    .Wait(50)
                    .LeftClick(window.FromTopLeft(x, 200));
            }
            else if (yPos < window.Height - 90)
            {
                actions
                    .Wait(100)
                    .LeftClick(window.FromTopLeft(x, yPos - 65)); // Click on the next chat
            }
            else
            {
                // Click on the last chat
                actions
                  .LeftClick(window.FromBottomLeft(x, -100))
                  .MouseWheel(90)
                  .MovePointer(window.FromBottomLeft(x, -100));
            }
        }

    }
}


