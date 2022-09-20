using Utils.Handlers;
using Utils.WinApi;
using Utils.Window;
using System.Linq;

namespace Accelerators.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        private readonly IHandler _nextHandler;

        protected WindowActions Actions { get; }
        protected abstract VirtualKey[] AcceleratorKeys { get; }
        protected abstract void SendKeys(WindowGeometry window);

        public HandlerBase(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            Actions = new WindowActions();
        }

        public HandlerBase() : this(NullHandler.Instance) { }

        public void Handle(WindowGeometry window)
        {
            if (RequestShouldBeProcessed())
            {
                if (KeyWasPressedTwice())
                {
                    new DoubleKeyPressHandler()
                        .Handle(SendKeys, window, AcceleratorKeys.First());
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

        private bool RequestShouldBeProcessed() =>
            AcceleratorKeys.All(k => Actions.KeyIsPressed(k));

        private bool KeyWasPressedTwice() =>
            AcceleratorKeys.Count() == 2 &&
            AcceleratorKeys.Distinct().Count() == 1;
    }
}
