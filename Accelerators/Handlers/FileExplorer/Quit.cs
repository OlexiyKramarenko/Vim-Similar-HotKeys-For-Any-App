using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Find
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


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_MENU)
            .SendKey(VirtualKey.VK_F4)
            .SendKeyUp(VirtualKey.VK_MENU);
    }
}


