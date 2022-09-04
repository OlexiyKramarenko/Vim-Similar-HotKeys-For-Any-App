using Utils.WinApi;
using Utils.Window;

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


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_CONTROL, VirtualKey.Z_key)
            .LeftClick(window.InCenter);

    }
} 
