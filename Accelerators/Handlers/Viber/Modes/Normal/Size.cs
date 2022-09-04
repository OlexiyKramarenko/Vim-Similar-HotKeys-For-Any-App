using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class Size : HandlerBase
    {

        public Size() { }
        public Size(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.S_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_BACK)
            .RightClick(window.FromTopRight(-300, 20))
            .Press(VirtualKey.VK_DOWN, times: 3)
            .Press(VirtualKey.VK_RETURN);

    }
}


