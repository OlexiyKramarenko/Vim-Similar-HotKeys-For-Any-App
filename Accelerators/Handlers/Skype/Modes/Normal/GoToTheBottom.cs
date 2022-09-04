using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class GoToTheBottom : HandlerBase
    {

        public GoToTheBottom() { }
        public GoToTheBottom(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_SHIFT, VirtualKey.G_key)
            .Wait(200)
            .LeftClick(window.FromBottomRight(-50, -110))
            .LeftClick(window.FromBottomRight(-50, -110));

    }
}
