using Accelerators.Handlers;
using Accelerators.Handlers.LibreOffice.Modes.Normal;
using Accelerators.Modes.Implementation;
using Utils.Window;

namespace Accelerators.Processors.Implementation
{
    public class LibreOfficeProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public LibreOfficeProcessor()
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
