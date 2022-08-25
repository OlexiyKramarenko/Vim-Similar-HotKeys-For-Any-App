using Accelerators.Handlers.Viber;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors
{
    public class ViberProcessor : Processor
    {

        private readonly WinApiWrapper _winApi;

        public ViberProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
             new Exit(
              new FirstChat(
               new Maximize(
                new Minimize(
                 new Move(
                  new NextChat(
                   new NextChat2(
                    new PageDown(
                     new PageUp(
                      new PageUp2(
                       new PrevChat(
                        new Size(
                         new ToTheBottomOfThePage(
                          new ToTheTopOfThePage())))))))))))));

            chain.Handle(hwnd, _winApi);
        }

    }
}
