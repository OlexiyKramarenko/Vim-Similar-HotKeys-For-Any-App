using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToFindMode : HandlerBase
    {

        public GoToFindMode() { }
        public GoToFindMode(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_2 // Forward slash
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            winApi
           .Wait(100)
           .SendKeyDown(VirtualKey.VK_CONTROL)
           .SendKey(VirtualKey.F_key)
           .SendKeyUp(VirtualKey.VK_CONTROL);

            ModeContext.Instance.UpdateState(new FindState());
        }

    }
}


