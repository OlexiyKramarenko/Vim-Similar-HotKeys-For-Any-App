using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class SelectDownwards : HandlerBase
    {

        public SelectDownwards() { }
        public SelectDownwards(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.V_key,
            VirtualKey.J_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_SHIFT);
    }
}


