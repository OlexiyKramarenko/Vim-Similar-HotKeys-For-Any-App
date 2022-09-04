using Accelerators.Handlers;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class GoToVisualMode : HandlerBase
    {
        private readonly ModeContext _modeContext;

        public GoToVisualMode(ModeContext modeContext)
        {
            _modeContext = modeContext;
        }

        public GoToVisualMode(ModeContext modeContext, IHandler next) : base(next)
        {
            _modeContext = modeContext;
        }
        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.V_key
        };


        protected override void SendKeys(Window window)
        {
            actions.Press(VirtualKey.VK_SHIFT);

            _modeContext.UpdateState(new VisualState());
        }

    }
}


