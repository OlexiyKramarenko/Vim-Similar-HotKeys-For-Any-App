using Accelerators.Handlers;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

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


        protected override void SendKeys(Window window)
        {
            actions.Press(VirtualKey.VK_CONTROL, VirtualKey.F_key);

            _modeContext.UpdateState(new FindState());
        }
    }
}


