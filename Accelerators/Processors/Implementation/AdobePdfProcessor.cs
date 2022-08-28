using Accelerators.Handlers.AdobePdfReader;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    internal class AdobePdfProcessor : IProcessor
    {

        private readonly WinApiWrapper _winApi;

        public AdobePdfProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
               new AddStickNote(
                new CloseTreeNode(
                 new EndOfLine(
                  new EndOfTheWord(
                   new Escape(
                    new Highlight(
                     new MoveDown(
                      new MoveLeft(
                       new MoveRight(
                        new MoveUp(
                         new OpenTreeNode(
                          new PageDown(
                           new PageUp(
                            new PrevWord(
                             new StartOfLine(
                              new StartOfTheWord(
                               new ToTheBottomOfPage(
                                new ToTheTopOfPage())))))))))))))))));

            chain.Handle(hwnd, _winApi);
        }

    }
}
