using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
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


        protected override void SendKeys(Window window)
        {
            actions.MovePointer(window.FromTopLeft(310, 300));

            for (int i = 0; i < 30; i++)
            {
                actions
                  .MouseWheel(500)
                  .Wait(200);
            }
        }

    }
}
