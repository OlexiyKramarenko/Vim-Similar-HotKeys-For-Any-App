using Utils.WinApi;
using Utils.Window;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class CloseTreeNode : HandlerBase
    {

        public CloseTreeNode() { }
        public CloseTreeNode(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.O_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Wait(100)
           .Press(VirtualKey.VK_LEFT);

    }
}


