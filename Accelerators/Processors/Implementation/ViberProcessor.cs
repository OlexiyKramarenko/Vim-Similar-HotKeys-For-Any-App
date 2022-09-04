using Accelerators.Handlers;
using Accelerators.Handlers.Viber.Modes.Normal;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class ViberProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public ViberProcessor() : base(new WindowActions(), new ModeContext())
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(NormalState),
                                new Exit(
                                 new ChatBelow(
                                  new Maximize(
                                   new Minimize(
                                    new Move(
                                     new NextChat(
                                      new NextChat(
                                       new WheelDown(
                                        new WheelUp(
                                         new ChatAbove(
                                          new Size(
                                           new ToPageBottom(
                                            new ToPageTop())))))))))))) }
            };
        }
    }
}
