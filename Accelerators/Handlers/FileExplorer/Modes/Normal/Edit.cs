using Accelerators.Handlers;
using Accelerators.Handlers.FileExplorer.Modes;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Normal
{
    public class Edit : HandlerBase
    {

        private readonly ModeContext _modeContext;

        public Edit(ModeContext modeContext)
        {
            _modeContext = modeContext;
        }

        public Edit(ModeContext modeContext, IHandler next) : base(next)
        {
            _modeContext = modeContext;
        }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.R_key
        };


        protected override void SendKeys(Window window)
        {
            actions.Press(VirtualKey.VK_F2);

            _modeContext.UpdateState(new InsertState());
        }

    }
}


