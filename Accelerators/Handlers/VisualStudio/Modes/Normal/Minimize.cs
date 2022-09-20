using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.VisualStudio.Modes.Normal
{
    public class Minimize : HandlerBase
    {

        public Minimize() { }
        public Minimize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.N_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_ESCAPE)
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_SPACE)
            .Press(VirtualKey.VK_DOWN, times: 3)
            .Press(VirtualKey.VK_RETURN);

    }
}


