using Accelerators.Handlers.FileExplorer.Modes;
using SMMTool.Utils.WindowsApi;
using System.Drawing;
using Find = Accelerators.FileExplorer.Modes.Find;
using Insert = Accelerators.FileExplorer.Modes.Insert;
using Normal = Accelerators.FileExplorer.Modes.Normal;

namespace Accelerators.Processors.Implementation
{
    public class FileExplorerProcessor : IProcessor
    {

        private WinApiWrapper _winApi;

        public FileExplorerProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }


        public void Process(IntPtr hwnd)
        {
            Thread.Sleep(70);

            ToolTip
              .Instance(hwnd, ModeContext.Instance.ModeName)
              .Show(TooltipLocation(hwnd));

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
            chain.Handle(hwnd, _winApi);
        }


        private Point TooltipLocation(IntPtr hwnd)
        {
            var x = _winApi.GetWindowLeftX(hwnd);
            var y = _winApi.GetWindowBottomY(hwnd);
            return new Point(x + 5, y - 6);
        }

    }
}
