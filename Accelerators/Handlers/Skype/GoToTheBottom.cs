using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class GoToTheBottom : HandlerBase
    {

        public GoToTheBottom() { }
        public GoToTheBottom(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_SHIFT,
            VirtualKey.G_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.G_key)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .SendKeyUp(VirtualKey.VK_CONTROL)
            .Wait(200)
            .LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-50, -110))
            .LeftMouseClickRelatedToBottomRightCornerOfWindow(hwnd, new POINT(-50, -110));

    }
}
