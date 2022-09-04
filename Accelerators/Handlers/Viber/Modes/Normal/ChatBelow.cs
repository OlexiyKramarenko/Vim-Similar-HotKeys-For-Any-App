using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber.Modes.Normal
{
    public class ChatBelow : HandlerBase
    {

        public ChatBelow() { }
        public ChatBelow(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.I_key
        };


        protected override void SendKeys(Window window) => actions
            .LeftClick(window.FromTopLeft(80, 165));

    }
}


