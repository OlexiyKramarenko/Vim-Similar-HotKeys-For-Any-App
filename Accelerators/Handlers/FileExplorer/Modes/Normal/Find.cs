using Accelerators.Handlers;
using Accelerators.Modes;
using Accelerators.Modes.Implementation;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.FileExplorer.Modes.Normal
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


        protected override void SendKeys(WindowGeometry window)
        {
            Actions.Press(VirtualKey.VK_CONTROL, VirtualKey.F_key);

            _modeContext.UpdateState(new FindState());
        }
    }
}


