using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
{
    public class Quit : HandlerBase
    {

        public Quit() { }
        public Quit(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.Q_key,
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_F4);

    }
}


