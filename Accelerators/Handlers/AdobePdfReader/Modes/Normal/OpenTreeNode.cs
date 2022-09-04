using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window) => actions
           .Press(VirtualKey.VK_RIGHT);

    }
}


