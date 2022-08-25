using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice
{
    public class ToggleCase : HandlerBase
    {

        public ToggleCase() { }
        public ToggleCase(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_3
        };

        // ~   Tools -> Customize -> Format -> Toggle case
        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_F10)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .Wait(100);

    }
}


