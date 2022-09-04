using Accelerators.Handlers;
using Accelerators.Handlers.LibreOffice.Modes.Normal;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class LibreOfficeProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public LibreOfficeProcessor() : base(new WindowActions(), new ModeContext())
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(NormalState),
                               new Highlight(
                                new Minimize(
                                 new MoveWindow(
                                  new RemoveSpaces(
                                   new StartVimAddon(
                                    new ToggleCase(
                                     new Maximize())))))) }
            };
        }
    }
}
