using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class EndOfLine : HandlerBase
    {

        public EndOfLine() { }
        public EndOfLine(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey._8_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .LeftMouseClickOnTheCenterOfWindow(hwnd)
            .SendKey(VirtualKey.VK_END);
    }
}


