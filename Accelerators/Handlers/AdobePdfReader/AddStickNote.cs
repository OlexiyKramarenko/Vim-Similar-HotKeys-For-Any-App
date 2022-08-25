using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class AddStickNote : HandlerBase
    {

        public AddStickNote() { }
        public AddStickNote(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_6 // "]"
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKey(VirtualKey.VK_LEFT)
            .SendKeyUp(VirtualKey.VK_CONTROL)
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_CONTROL)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_RIGHT)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .SendKeyUp(VirtualKey.VK_CONTROL)
            .Wait(100)
            .SendKeyDown(VirtualKey.VK_SHIFT)
            .SendKey(VirtualKey.VK_F10)
            .SendKeyUp(VirtualKey.VK_SHIFT)
            .Wait(100)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_DOWN)
            .SendKey(VirtualKey.VK_RETURN);

    }
}


