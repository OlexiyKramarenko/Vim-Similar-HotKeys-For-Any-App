using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
{
    public class ToggleCase : HandlerBase
    {

        public ToggleCase() { }
        public ToggleCase(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_3  // "~"
        };

        // ~   Tools -> Customize -> Format -> Toggle case
        protected override void SendKeys(Window window) => actions
            .Wait(100)
            .Press(VirtualKey.VK_SHIFT, VirtualKey.VK_F10)
            .Wait(100);

    }
}


