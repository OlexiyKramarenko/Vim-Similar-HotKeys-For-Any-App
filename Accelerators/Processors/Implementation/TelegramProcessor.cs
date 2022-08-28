using Accelerators.Handlers.Telegram;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class TelegramProcessor : IProcessor
    {
        private readonly WinApiWrapper _winApi;

        public TelegramProcessor(WinApiWrapper winApi)
        {
            _winApi = winApi;
        }

        public void Process(IntPtr hwnd)
        {
            var chain =
             new ChatDown(
              new ChatUp(
               new Down(
                new Escape(
                 new Exit(
                  new Minimize(
                   new Minimize2(
                    new Move(
                     new Size(
                      new ToPageBottom(
                       new ToPageTop(
                        new Up(
                         new Maximize()))))))))))));

            chain.Handle(hwnd, _winApi);
        }
    }
}
