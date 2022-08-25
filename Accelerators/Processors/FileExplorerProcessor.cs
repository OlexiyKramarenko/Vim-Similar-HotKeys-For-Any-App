using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using Find = Accelerators.FileExplorer.Modes.Find;
using Insert = Accelerators.FileExplorer.Modes.Insert;
using Normal = Accelerators.FileExplorer.Modes.Normal;

namespace Accelerators.Processors
{
    public class FileExplorerProcessor
    {

        private ToolTip _toolTip;
        private WinApiWrapper _winApiWrapper;

        public FileExplorerProcessor(WinApiWrapper winApiWrapper)
        {
            _winApiWrapper = winApiWrapper;
        }


        public void Process(IntPtr hwnd)
        {
            Thread.Sleep(70);

            var chain =
            new Find.Escape(
             new Insert.Escape(
              new Insert.Escape2(
               new Insert.Return(
                new Normal.AddDirectory(
                 new Normal.AddFile(
                  new Normal.Copy(
                   new Normal.CopyName(
                    new Normal.CopyPath(
                     new Normal.Delete(
                      new Normal.Edit(
                       new Normal.Find(
                        new Normal.GoToFindMode(
                         new Normal.GoToFirstChild(
                          new Normal.GoToLastChild(
                           new Normal.GoToMainPane(
                            new Normal.GoToNavigationPane(
                             new Normal.GoToParent(
                              new Normal.GoToTheBottom(
                               new Normal.GoToTheTop(
                                new Normal.GoToVisualMode(
                                 new Normal.HistoryBackwards(
                                  new Normal.HistoryForward(
                                   new Normal.MoveDown(
                                    new Normal.MoveLeft(
                                     new Normal.MoveRight(
                                      new Normal.MoveUp(
                                       new Normal.Paste(
                                        new Normal.Redo(
                                         new Normal.SelectDownwards(
                                          new Normal.SelectUpwards(
                                           new Normal.Undo())))))))))))))))))))))))))))))));

            chain.Handle(hwnd, _winApiWrapper);

            DisplayTooltip(ModeContext.Instance.ModeName);
        }


        public void SetTooltip(ToolTip m_ttip)
        {
            _toolTip = m_ttip;
        }


        private void DisplayTooltip(string text)
        {
            _toolTip.strText = text;
        }

    }
}
