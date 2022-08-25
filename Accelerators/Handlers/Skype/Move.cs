using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class Move : HandlerBase
    {

        public Move() { }
        public Move(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.M_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .RightMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-200, 20))
            .Wait(100)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_RETURN);

    }
}


