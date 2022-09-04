using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.Chrome.Modes.Normal
{
    public class BookmarksList : HandlerBase
    {

        public BookmarksList() { }
        public BookmarksList(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_CONTROL,
            VirtualKey.B_key,
            VirtualKey.N_key
        };


        protected override void SendKeys(Window window) => actions
            .Press(VirtualKey.VK_CONTROL, 
                   VirtualKey.VK_SHIFT, 
                   VirtualKey.O_key);

    }
}


