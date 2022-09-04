using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class CloseAllDocuments : HandlerBase
    {

        public CloseAllDocuments() { }
        public CloseAllDocuments(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.A_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_F4);

    }
}


