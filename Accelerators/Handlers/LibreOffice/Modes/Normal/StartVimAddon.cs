using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
{
    public class StartVimAddon : HandlerBase
    {

        public StartVimAddon() { }
        public StartVimAddon(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_OEM_6   // "]"
        };


        protected override void SendKeys(Window window) => actions
            .Wait(200)
            .Press(VirtualKey.VK_MENU, VirtualKey.T_key)
            .Wait(100)
            .Press(VirtualKey.VK_END)
            .Press(VirtualKey.VK_RIGHT)
            .Wait(100)
            .Press(VirtualKey.VK_MENU, VirtualKey.V_key);

    }
}


