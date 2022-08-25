using SMMTool.Utils.WindowsApi;
using Utils;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        private readonly IHandler _nextHandler;
        protected abstract void SendKeys(IntPtr hwnd, WinApiWrapper winApi);
        protected abstract VirtualKey[] AcceleratorKeys { get; }

        public HandlerBase(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public HandlerBase() : this(NullHandler.Instance) { }

        public void Handle(IntPtr hwnd, WinApiWrapper winApi)
        { 
            if (RequestShouldBeProcessed(winApi))
            {
                SendKeys(hwnd, winApi);
            }
            else
            {
                _nextHandler.Handle(hwnd, winApi);
            }
        }

        private bool RequestShouldBeProcessed(WinApiWrapper winApi) =>
            AcceleratorKeys.All(k => winApi.KeyIsPressed(k));
    }
}
