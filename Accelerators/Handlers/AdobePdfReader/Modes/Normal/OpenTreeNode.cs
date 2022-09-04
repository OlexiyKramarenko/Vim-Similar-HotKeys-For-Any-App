using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class OpenTreeNode : HandlerBase
    {

        public OpenTreeNode() { }
        public OpenTreeNode(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.O_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Press(VirtualKey.VK_RIGHT);

    }
}


