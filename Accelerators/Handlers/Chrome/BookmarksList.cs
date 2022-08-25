using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class BookmarksList : HandlerBase
    {

        public BookmarksList() { }
        public BookmarksList(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.B_key,
            VirtualKey.N_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.O_key)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


