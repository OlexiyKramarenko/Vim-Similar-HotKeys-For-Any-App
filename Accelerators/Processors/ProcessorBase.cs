using Accelerators.Handlers;
using Accelerators.Modes;
using System.Drawing;
using Utils.WinApi;
using Utils.Window;

namespace Accelerators.Processors
{
    public abstract class ProcessorBase
    {
        protected ModeContext ModeContext { get; }

        public ProcessorBase()
        {
            ModeContext = new ModeContext();
        }


        protected abstract Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public virtual void Process(WindowGeometry window)
        {
            var state = ModeContext.State.GetType();

            if (StateHandlerDictionary.ContainsKey(state))
            {
                StateHandlerDictionary[state].Handle(window);
            }
        }

        protected void ShowTooltip(WindowGeometry window)
        {
            ToolTip
              .Instance(window.Hwnd, ModeContext.ModeName)
              .ShowTooltip(TooltipLocation(window));
        }

        private Point TooltipLocation(WindowGeometry geometry)
        {
            var x = geometry.LeftX;
            var y = geometry.BottomY;
            return new Point(x + 5, y - 6);
        }

    }
}
