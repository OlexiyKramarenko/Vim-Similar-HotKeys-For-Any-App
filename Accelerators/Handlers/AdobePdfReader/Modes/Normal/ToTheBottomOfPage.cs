using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class ToTheBottomOfPage : HandlerBase
    {

        public ToTheBottomOfPage() { }
        public ToTheBottomOfPage(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.G_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Wait(100)
            .Press(VirtualKey.VK_NEXT, times: 2);

    }
}


