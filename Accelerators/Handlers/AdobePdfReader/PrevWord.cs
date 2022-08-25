using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class PrevWord : HandlerBase
    {

        public PrevWord() { }
        public PrevWord(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.B_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .SendKeyDown(VirtualKey.VK_CONTROL)
           .SendKey(VirtualKey.VK_LEFT)
           .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


