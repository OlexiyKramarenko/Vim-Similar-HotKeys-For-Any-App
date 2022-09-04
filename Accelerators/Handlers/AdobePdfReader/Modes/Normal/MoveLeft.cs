using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class MoveLeft : HandlerBase
    {

        public MoveLeft() { }
        public MoveLeft(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.H_key
        };


        protected override void SendKeys(Window window) => actions
           .Wait(100)
           .Press(VirtualKey.VK_LEFT);

    }
}
