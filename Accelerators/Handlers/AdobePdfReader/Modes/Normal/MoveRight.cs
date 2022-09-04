using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class MoveRight : HandlerBase
    {

        public MoveRight() { }
        public MoveRight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.L_key
        };


        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_RIGHT);

    }
}
