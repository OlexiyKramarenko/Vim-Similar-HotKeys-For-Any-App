using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
{
    public class Maximize : HandlerBase
    {

        public Maximize() { }
        public Maximize(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_F11
        };


        protected override void SendKeys(Window window) => actions
            .LeftClick(window.FromTopRight(-76, 17));

    }
}


