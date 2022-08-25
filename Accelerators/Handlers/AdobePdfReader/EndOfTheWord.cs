using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class EndOfTheWord : HandlerBase
    {

        public EndOfTheWord() { }
        public EndOfTheWord(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.E_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .SendKey(VirtualKey.VK_RIGHT)
           .SendKeyDown(VirtualKey.VK_CONTROL)
           .SendKey(VirtualKey.VK_RIGHT)
           .SendKeyUp(VirtualKey.VK_CONTROL)
           .SendKey(VirtualKey.VK_LEFT);

    }
}


