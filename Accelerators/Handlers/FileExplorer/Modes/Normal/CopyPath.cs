using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
{
    public class CopyPath : HandlerBase
    {

        public CopyPath() { }
        public CopyPath(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.P_key,
            VirtualKey.Y_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_RETURN)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.L_key)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.C_key)
            .Press(VirtualKey.VK_TAB, times: 2);

    }
}


