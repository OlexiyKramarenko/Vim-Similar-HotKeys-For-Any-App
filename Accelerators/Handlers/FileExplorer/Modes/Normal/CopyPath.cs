using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class CopyPath : HandlerBase
    {

        public CopyPath() { }
        public CopyPath(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.P_key,
            VirtualKey.Y_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKey(VirtualKey.VK_RETURN)

            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.L_key)
            .SendKeyUp(VirtualKey.VK_CONTROL)

            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.C_key)
            .SendKeyUp(VirtualKey.VK_CONTROL)

            .SendKey(VirtualKey.VK_TAB)
            .SendKey(VirtualKey.VK_TAB);

    }
}


