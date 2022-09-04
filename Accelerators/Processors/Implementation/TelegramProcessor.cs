using Accelerators.Handlers;
using Accelerators.Handlers.Telegram.Modes.Normal;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class TelegramProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public TelegramProcessor() : base(new WindowActions(), new ModeContext())
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(NormalState),
                              new ChatBelow(
                               new ChatAbove(
                                new WheelDown(
                                 new Escape(
                                  new Exit(
                                   new Minimize(
                                    new Minimize(
                                     new Move(
                                      new Size(
                                       new ToPageBottom(
                                        new ToPageTop(
                                         new WheelUp(
                                          new Maximize())))))))))))) }
            };
        }
    }
}
