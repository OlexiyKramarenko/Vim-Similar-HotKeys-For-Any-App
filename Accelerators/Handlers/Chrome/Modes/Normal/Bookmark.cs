using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class Bookmark : HandlerBase
    {

        public Bookmark() { }
        public Bookmark(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.B_key,
            VirtualKey.H_key,
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.W_key)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.D_key);

    }
}


