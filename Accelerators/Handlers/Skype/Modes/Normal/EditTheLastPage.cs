using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class EditTheLastPage : HandlerBase
    {

        public EditTheLastPage() { }
        public EditTheLastPage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_UP
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_SHIFT, VirtualKey.VK_TAB)
            .Press(VirtualKey.VK_SHIFT, VirtualKey.VK_TAB)
            .Press(VirtualKey.VK_UP);

    }
}
