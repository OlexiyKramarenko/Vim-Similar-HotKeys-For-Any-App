using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class CopyName : HandlerBase
    {

        public CopyName() { }
        public CopyName(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.W_key,
            VirtualKey.Y_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKey(VirtualKey.VK_F2)
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.C_key)
            .SendKeyUp(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.VK_ESCAPE);

    }
}


