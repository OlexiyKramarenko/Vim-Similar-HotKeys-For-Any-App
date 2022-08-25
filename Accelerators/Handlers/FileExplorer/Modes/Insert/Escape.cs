using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Insert
{
    public class Escape : HandlerBase
    {

        public Escape() { }
        public Escape(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_ESCAPE
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi)
        {
            winApi.SendKey(VirtualKey.VK_ESCAPE);

            ModeContext.Instance
                       .UpdateState(new NormalState());
        }
    }
}


