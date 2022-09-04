using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class History : HandlerBase
    {

        public History() { }
        public History(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_LCONTROL,
            VirtualKey.G_key,
            VirtualKey.W_key
        };


        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.VK_SHIFT, VirtualKey.T_key)
            .Press(VirtualKey.VK_CONTROL, VirtualKey.H_key);

    }
}


