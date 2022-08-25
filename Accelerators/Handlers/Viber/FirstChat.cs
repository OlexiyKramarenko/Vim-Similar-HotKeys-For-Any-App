using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Viber
{
    public class FirstChat : HandlerBase
    {

        public FirstChat() { }
        public FirstChat(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.I_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickRelatedToTopLeftCornerOfWindow(hwnd, new POINT(80, 165));

    }
}


