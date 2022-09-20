using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
{
    public class HistoryForward : HandlerBase
    {

        public HistoryForward() { }
        public HistoryForward(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.L_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_LEFT);
    }
}


