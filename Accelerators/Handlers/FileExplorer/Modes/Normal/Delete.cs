using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class Delete : HandlerBase
    {

        public Delete() { }
        public Delete(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.D_key,
            VirtualKey.D_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_DELETE)
            .Wait(200)
            .Press(VirtualKey.VK_F5);
    }
}


