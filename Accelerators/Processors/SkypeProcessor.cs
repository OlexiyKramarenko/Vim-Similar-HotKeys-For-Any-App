using Accelerators.Handlers.Skype;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    public class SkypeProcessor : Processor
    {

        private readonly WinApiWrapper _winApi;

        public SkypeProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
              new ChatAbove(
               new ChatBelow(
                new EditTheLastPage(
                 new Exit(
                  new GoToTheBottom(
                   new Minimize(
                    new Move(
                     new Size(
                      new WheelDown(
                       new WheelUp(
                        new Maximize()))))))))));

            chain.Handle(hwnd, _winApi);
        }

    }
}
