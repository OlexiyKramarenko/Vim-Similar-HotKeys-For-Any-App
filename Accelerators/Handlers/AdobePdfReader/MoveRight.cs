using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class MoveRight : HandlerBase
    {

        public MoveRight() { }
        public MoveRight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.L_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .SendKey(VirtualKey.VK_RIGHT);

    }
}
