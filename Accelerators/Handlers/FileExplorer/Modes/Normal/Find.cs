using Accelerators.Handlers;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class Find : HandlerBase
    {

        private readonly ModeContext _modeContext;

        public Find(ModeContext modeContext)
        {
            _modeContext = modeContext;
        }

        public Find(ModeContext modeContext, IHandler next) : base(next)
        {
            _modeContext = modeContext;
        }

        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.F_key
        };


        protected override void SendKeys(Window window)
        {
            actions.Press(VirtualKey.VK_CONTROL, VirtualKey.F_key);

            _modeContext.UpdateState(new FindState());
        }
    }
}


