using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        protected readonly WindowActions actions;
        private readonly DoubleKeyPressHandler _twiceKeyPressHandler;
        private readonly IHandler _nextHandler;
        protected abstract void SendKeys(Window window);
        protected abstract VirtualKey[] AcceleratorKeys { get; }

        public HandlerBase(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            actions = new WindowActions();
            _twiceKeyPressHandler = new DoubleKeyPressHandler();
        }

        public HandlerBase() : this(NullHandler.Instance) { }


        public void Handle(Window window)
        {
            if (RequestShouldBeProcessed(actions))
            {
                if (KeyWasPressedTwice())
                {
                    _twiceKeyPressHandler.Handle(SendKeys, window, AcceleratorKeys.First());
                }
                else
                {
                    SendKeys(window);
                }
            }
            else
            {
                _nextHandler.Handle(window);
            }
        }

        private bool RequestShouldBeProcessed(WindowActions actions) =>
            AcceleratorKeys.All(k => actions.KeyIsPressed(k));

        private bool KeyWasPressedTwice() =>
            AcceleratorKeys.Count() == 2 &&
            AcceleratorKeys.Distinct().Count() == 1;
    }
}
