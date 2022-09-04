using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToMainPane : HandlerBase
    {

        public GoToMainPane() { }
        public GoToMainPane(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.VK_OEM_1  // ";"
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.F_key)
            .Press(VirtualKey.VK_TAB, times: 2);

    }
}
