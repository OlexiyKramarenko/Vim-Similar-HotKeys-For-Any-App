using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class Elements : HandlerBase
    {

        public Elements() { }
        public Elements(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.VK_OEM_1 // ";"
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_CONTROL, 
                   VirtualKey.VK_SHIFT,
                   VirtualKey.C_key);

    }
}


