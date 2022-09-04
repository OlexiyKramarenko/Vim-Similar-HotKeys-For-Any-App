using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class HistoryBackwards : HandlerBase
    {

        public HistoryBackwards() { }
        public HistoryBackwards(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.H_key
        };

        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_UP);
    }
}


