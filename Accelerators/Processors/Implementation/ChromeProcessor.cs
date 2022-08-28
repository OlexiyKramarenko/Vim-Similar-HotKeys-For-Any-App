using Accelerators.Handlers.AdobePdfReader;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class ChromeProcessor : IProcessor
    {

        private readonly WinApiWrapper _winApi;

        public ChromeProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
                new Bookmark(
                 new BookmarksList(
                  new CloseAllDocuments(
                   new CloseProgram(
                    new CloseTab(
                     new ConsoleTab(
                      new CreateTab(
                       new Elements(
                        new Extensions(
                         new History(
                          new NextTab(
                           new PinTab(
                            new PrevTab(
                             new ReopenClosedTab())))))))))))));

            chain.Handle(hwnd, _winApi);
        }

    }
}
