using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.LibreOffice.Modes.Normal
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


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(200)
            .Press(VirtualKey.VK_END)
            .Wait(100)
            .Press(VirtualKey.VK_DELETE);

    }
}


