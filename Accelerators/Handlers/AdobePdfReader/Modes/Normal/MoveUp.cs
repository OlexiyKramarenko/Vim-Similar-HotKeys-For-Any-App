using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class MoveUp : HandlerBase
    {

        public MoveUp() { }
        public MoveUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.K_key
        };


        protected override void SendKeys(Window window) => actions
           .Wait(100)
           .Press(VirtualKey.VK_UP);

    }
}
