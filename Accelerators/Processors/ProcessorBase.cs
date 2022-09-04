using Accelerators.Handlers;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;
using System.Drawing;

namespace Accelerators.Processors
{
    public abstract class ProcessorBase
    {
        private readonly WindowActions _actions;
        protected ModeContext ModeContext { get; }

        public ProcessorBase(WindowActions actions, ModeContext modeContext)
        {
            _actions = actions;
            ModeContext = modeContext;
        }


        protected abstract Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public virtual void Process(Window window)
        {
            var state = ModeContext.State.GetType();

            if (StateHandlerDictionary.ContainsKey(state))
            {
                StateHandlerDictionary[state].Handle(window);
            }
        }

        protected void ShowTooltip(Window window)
        {
            ToolTip
              .Instance(window.Hwnd, ModeContext.ModeName)
              .Show(TooltipLocation(window.Hwnd));
        }

        private Point TooltipLocation(IntPtr hwnd)
        {
            var x = _actions.GetWindowLeftX(hwnd);
            var y = _actions.GetWindowBottomY(hwnd);
            return new Point(x + 5, y - 6);
        }

    }
}
