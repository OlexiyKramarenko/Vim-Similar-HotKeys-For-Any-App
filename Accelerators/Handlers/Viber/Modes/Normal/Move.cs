using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
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


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_BACK)
            .RightClick(window.FromTopRight(-300, 20))
            .Press(VirtualKey.VK_DOWN, times: 2)
            .Press(VirtualKey.VK_RETURN);

    }
}


