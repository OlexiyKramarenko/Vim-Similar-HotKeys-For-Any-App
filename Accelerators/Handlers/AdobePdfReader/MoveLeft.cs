using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class MoveLeft : HandlerBase
    {

        public MoveLeft() { }
        public MoveLeft(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.H_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .SendKey(VirtualKey.VK_LEFT);

    }
}
