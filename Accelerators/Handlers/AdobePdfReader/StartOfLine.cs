using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class StartOfLine : HandlerBase
    {

        public StartOfLine() { }
        public StartOfLine(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey._4_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .SendKey(VirtualKey.VK_HOME);

    }
}
