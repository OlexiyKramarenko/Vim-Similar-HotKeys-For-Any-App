using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Skype
{
    public class EditTheLastPage : HandlerBase
    {

        public EditTheLastPage() { }
        public EditTheLastPage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.VK_UP
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_TAB)
            .SendKeyUp(VirtualKey.VK_SHIFT) 
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_TAB)
            .SendKeyUp(VirtualKey.VK_SHIFT) 
            .SendKey(VirtualKey.VK_UP);

    }
}
