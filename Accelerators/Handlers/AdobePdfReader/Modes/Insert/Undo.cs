using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Insert
{
    public class Undo : HandlerBase
    {

        public Undo() { }
        public Undo(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.U_key,
            VirtualKey.VK_CONTROL
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.Z_key)
            .LeftClick(window.InCenter());

    }
}


