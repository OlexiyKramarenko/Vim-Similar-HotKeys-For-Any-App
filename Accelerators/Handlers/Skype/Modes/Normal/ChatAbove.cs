using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class ChatAbove : HandlerBase
    {

        public ChatAbove() { }
        public ChatAbove(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.K_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL,
                   VirtualKey.VK_SHIFT,
                   VirtualKey.VK_TAB);

    }
}


