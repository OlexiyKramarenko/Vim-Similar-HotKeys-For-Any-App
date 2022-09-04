using Accelerators.Handlers;
using Accelerators.Handlers.AdobePdfReader.Modes.Insert;
using Accelerators.Handlers.AdobePdfReader.Modes.Normal;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class AdobePdfProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public AdobePdfProcessor() : base(new WindowActions(), new ModeContext())
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(InsertState), new Undo() },

                { typeof(NormalState),
                           new AddStickNote(
                            new OpenTreeNode(
                             new EndOfLine(
                              new EndOfTheWord(
                               new Escape(
                                new Highlight(
                                 new MoveDown(
                                  new MoveLeft(
                                   new MoveRight(
                                     new MoveUp(
                                      new CloseTreeNode(
                                       new PageDown(
                                        new PageUp(
                                         new PrevWord(
                                          new StartOfLine(
                                           new StartOfTheWord(
                                            new ToTheBottomOfPage(
                                             new ToTheTopOfPage()))))))))))))))))) },
            };
        }
    }
}
