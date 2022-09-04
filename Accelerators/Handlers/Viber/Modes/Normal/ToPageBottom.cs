using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class ToPageBottom : HandlerBase
    {

        public ToPageBottom() { }
        public ToPageBottom(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(Window window) => actions
            .LeftClick(window.FromBottomRight(-38, -80))
            .LeftClick(window.FromBottomRight(-40, -58));

    }
}
