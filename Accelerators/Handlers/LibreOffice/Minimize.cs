using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice
{
    public class Minimize : HandlerBase
    {

        public Minimize() { }
        public Minimize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.N_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
           .LeftMouseClickRelatedToTopRightCornerOfWindow(hwnd, new POINT(-130, 17));

    }
}


