using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using Accelerators.Modes;
using Accelerators.Modes.Implementation;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Find
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
            VirtualKey.K_key,
            VirtualKey.J_key,
        };


        protected override void SendKeys(WindowGeometry window)
        {
            Actions.Press(VirtualKey.VK_ESCAPE);

            _modeContext.UpdateState(new NormalState());
        }
    }
}


