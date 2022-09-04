using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype.Modes.Normal
{
    public class Minimize : HandlerBase
    {

        public Minimize() { }
        public Minimize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.N_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_SPACE)
            .Wait(100)
            .Press(VirtualKey.N_key);

    }
}


