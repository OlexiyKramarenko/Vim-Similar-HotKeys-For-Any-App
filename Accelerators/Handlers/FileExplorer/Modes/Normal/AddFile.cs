using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
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


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.H_key)
            .SendKeyUp(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.W_key)
            .SendKey(VirtualKey.VK_UP)
            .SendKey(VirtualKey.VK_UP)
            .SendKey(VirtualKey.VK_RETURN);

    }
}


