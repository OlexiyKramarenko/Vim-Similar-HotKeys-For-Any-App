using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class Undo : HandlerBase
    {

        public Undo() { }
        public Undo(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.U_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
          .SendKeyDown(VirtualKey.VK_CONTROL)
          .SendKey(VirtualKey.Z_key)
          .SendKeyUp(VirtualKey.VK_CONTROL)
          .LeftMouseClickOnTheCenterOfWindow(hwnd);

    }
}


