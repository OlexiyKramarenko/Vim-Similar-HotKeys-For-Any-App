using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
{
    public class Highlight : HandlerBase
    {

        public Highlight() { }
        public Highlight(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_4 // "["
        };


        protected override void SendKeys(Window window) => actions
            .LeftClick(window.FromTopLeft(755, 100))
            .Wait(100)
            .LeftClick(window.FromTopLeft(755, 410));

    }
}


