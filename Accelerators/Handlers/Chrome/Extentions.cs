using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class Extensions : HandlerBase
    {

        public Extensions() { }
        public Extensions(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.N_key,
            VirtualKey.U_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .Wait(200)
            .SendKey(VirtualKey.VK_ESCAPE)
            .Wait(100)
            .SendKey(VirtualKey.VK_TAB)
            .Wait(100)
            .SendKey(VirtualKey.VK_MENU)
            .Wait(100)
            .SendKey(VirtualKey.VK_RETURN)
            .Wait(100)
            .SendKey(VirtualKey.L_key)
            .Wait(100)
            .SendKey(VirtualKey.E_key);

    }
}


