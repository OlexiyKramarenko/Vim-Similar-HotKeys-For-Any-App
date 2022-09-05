using Utils.Handlers;
using Utils.WinApi;
using Utils.Window;
using System.Linq;

namespace Accelerators.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        private readonly DoubleKeyPressHandler _twiceKeyPressHandler;
        private readonly IHandler _nextHandler;

        protected WindowActions Actions { get; }
        protected abstract VirtualKey[] AcceleratorKeys { get; }
        protected abstract void SendKeys(WindowGeometry window);

        public HandlerBase(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            Actions = new WindowActions();
            _twiceKeyPressHandler = new DoubleKeyPressHandler();
        }

        public HandlerBase() : this(NullHandler.Instance) { } 

        public void Handle(WindowGeometry window)
        {
            if (RequestShouldBeProcessed(Actions))
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
