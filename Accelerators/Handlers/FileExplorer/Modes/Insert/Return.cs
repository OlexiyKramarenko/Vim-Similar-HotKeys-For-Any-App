using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Insert
{
    public class Return : HandlerBase
    {

        public Return() { }
        public Return(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_RETURN
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_RETURN);
    }
}


