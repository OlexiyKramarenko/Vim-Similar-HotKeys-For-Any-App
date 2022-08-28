using Accelerators.Handlers.LibreOffice;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class LibreOfficeProcessor : IProcessor
    {

        private readonly WinApiWrapper _winApi;

        public LibreOfficeProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
                new Highlight(
                 new Minimize(
                  new MoveWindow(
                   new RemoveSpaces(
                    new StartVimAddon(
                     new ToggleCase(
                      new Maximize()))))));

            chain.Handle(hwnd, _winApi);
        }

    }
}
