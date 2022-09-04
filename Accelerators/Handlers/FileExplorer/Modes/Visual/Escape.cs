using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Visual
{
    public class Escape : HandlerBase
    {
        private readonly ModeContext _modeContext;

        public Escape(ModeContext modeContext)
        {
            _modeContext = modeContext;
        }

        public Escape(ModeContext modeContext, IHandler next) : base(next)
        {
            _modeContext = modeContext;
        }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_ESCAPE
        };


        protected override void SendKeys(Window window)
        {
            _modeContext.UpdateState(new NormalState());
        }
    }
}


