using Accelerators.Handlers;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
{
    public class AddFile : HandlerBase
    {

        public AddFile() { }
        public AddFile(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.A_key,
            VirtualKey.F_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            //.Press(VirtualKey.VK_MENU, VirtualKey.H_key)
            //.Press(VirtualKey.W_key)
            //.Wait(100)
            //.Press(VirtualKey.VK_UP, times: 2)
            //.Press(VirtualKey.VK_RETURN)
            ; 
    }
}


