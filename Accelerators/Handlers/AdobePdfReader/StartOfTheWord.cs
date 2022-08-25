using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class StartOfTheWord : HandlerBase
    {

        public StartOfTheWord() { }
        public StartOfTheWord(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.W_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .SendKey(VirtualKey.VK_RIGHT)
             .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


