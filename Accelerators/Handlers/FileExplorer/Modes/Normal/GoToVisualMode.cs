using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToVisualMode : HandlerBase
    {

        public GoToVisualMode() { }
        public GoToVisualMode(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.V_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            winApi
           .Wait(100)
           .SendKeyDown(VirtualKey.VK_CONTROL)
           .SendKey(VirtualKey.F_key)
           .SendKeyUp(VirtualKey.VK_CONTROL);

            ModeContext.Instance
                       .UpdateState(new VisualState());
        }

    }
}


