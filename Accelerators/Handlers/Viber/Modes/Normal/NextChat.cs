using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window)
        {
            var yPos = window.FromTopLeft().Y;

            var bottomOftheTopPanel = 160;

            var x = 170;

            if (yPos <= bottomOftheTopPanel)
            {
                actions.LeftClick(window.FromTopLeft(x, 168)); // Click on the first chat 
            }
            else if (yPos < window.Height - 140)
            {
                actions
                    .Wait(100)
                    .LeftClick(window.FromTopLeft(x, yPos + 65)); // Click on the next chat
            }
            else
            {
                actions
                    .Wait(50)
                    .MouseWheel(-55)
                    .Wait(50)
                    .MouseWheel(-55)
                    .Wait(50)
                    .LeftClick(window.FromBottomLeft(x, -50)); // Click on the last chat
            }
        }

    }
}


