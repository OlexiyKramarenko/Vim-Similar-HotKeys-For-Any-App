using Accelerators.Handlers;
using Accelerators.Modes;
using Accelerators.Modes.Implementation;
using Utils.Window;
using Utils.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class Find2 : HandlerBase
    {

        private readonly ModeContext _modeContext;

        public Find2(ModeContext modeContext)
        {
            _modeContext = modeContext;
        }

        public Find2(ModeContext modeContext, IHandler next) : base(next)
        {
            _modeContext = modeContext;
        }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_2  //  "/"
        };


        protected override void SendKeys(WindowGeometry window)
        {
            Actions.Press(VirtualKey.VK_CONTROL, VirtualKey.F_key);

            _modeContext.UpdateState(new FindState());
        }
    }
}


