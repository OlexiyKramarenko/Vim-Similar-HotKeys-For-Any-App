using Accelerators.Handlers;
using Accelerators.Modes.Implementation;
using Utils.Window;
using Find = Accelerators.FileExplorer.Modes.Find;
using Insert = Accelerators.FileExplorer.Modes.Insert;
using Normal = Accelerators.FileExplorer.Modes.Normal;
using Visual = Accelerators.FileExplorer.Modes.Visual;

namespace Accelerators.Processors.Implementation
{
    public class FileExplorerProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public FileExplorerProcessor()
        { 
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(VisualState), new Visual.Escape(ModeContext) },

                { typeof(FindState),   new Find.Escape(ModeContext) },

                { typeof(InsertState), new Insert.Escape(ModeContext,
                                       new Insert.Escape2(ModeContext,
                                       new Insert.Return())) },

                { typeof(NormalState),  new Normal.AddDirectory(
                                        new Normal.AddFile(
                                        new Normal.CopyName(
                                        new Normal.CopyPath(
                                        new Normal.Copy(
                                        new Normal.Delete(
                                        new Normal.Edit(ModeContext,
                                        new Normal.Find(ModeContext,
                                        new Normal.Find2(ModeContext,
                                        new Normal.GoToFirstChild(
                                        new Normal.GoToMainPane(
                                        new Normal.GoToNavigationPane(
                                        new Normal.GoToParent(
                                        new Normal.GoToTheBottom(
                                        new Normal.GoToTheTop(
                                        new Normal.GoToVisualMode(ModeContext,
                                        new Normal.HistoryBackwards(
                                        new Normal.HistoryForward(
                                        new Normal.MoveDown(
                                        new Normal.MoveLeft(
                                        new Normal.MoveRight(
                                        new Normal.MoveUp(
                                        new Normal.Paste(
                                        new Normal.Redo(
                                        new Normal.Undo())))))))))))))))))))))))) },
            };
        }

        public override void Process(WindowGeometry window)
        {
            ShowTooltip(window);
            base.Process(window);
        }

    }
}
