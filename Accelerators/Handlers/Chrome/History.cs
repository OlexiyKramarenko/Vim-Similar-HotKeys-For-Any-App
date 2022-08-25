using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class History : HandlerBase
    {

        public History() { }
        public History(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.G_key,
            VirtualKey.W_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .SendKey(VirtualKey.H_key)
             .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


