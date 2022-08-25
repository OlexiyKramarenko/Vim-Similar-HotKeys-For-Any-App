using SMMTool.Utils.WindowsApi;

namespace Accelerators.Handlers
{
    public interface IHandler
    {
        public void Handle(IntPtr hwnd, WinApiWrapper winApi);
    }
}
