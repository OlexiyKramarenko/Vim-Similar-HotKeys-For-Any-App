using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Insert
{
    public class Escape2 : HandlerBase
    {

        public Escape2() { }
        public Escape2(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.K_key,
            VirtualKey.J_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            winApi.SendKey(VirtualKey.VK_ESCAPE);

            ModeContext.Instance.UpdateState(new NormalState());
        }

    }
}


