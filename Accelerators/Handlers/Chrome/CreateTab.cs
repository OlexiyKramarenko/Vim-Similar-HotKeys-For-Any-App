using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class CreateTab : HandlerBase
    {

        public CreateTab() { }
        public CreateTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.A_key,
            VirtualKey.F_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.T_key)
            .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


