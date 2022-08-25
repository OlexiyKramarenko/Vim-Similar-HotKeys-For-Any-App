using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice
{
    public class RemoveSpaces : HandlerBase
    {

        public RemoveSpaces() { }
        public RemoveSpaces(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_SHIFT,
            VirtualKey.J_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .Wait(200)
            .SendKey(VirtualKey.VK_END)
            .Wait(100)
            .SendKey(VirtualKey.VK_DELETE);

    }
}


