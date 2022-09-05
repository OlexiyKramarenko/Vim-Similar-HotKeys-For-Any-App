using Accelerators.Handlers;
using Accelerators.Handlers.Viber.Modes.Normal;
using Accelerators.Modes.Implementation;
using System;
using System.Collections.Generic;

namespace Accelerators.Processors.Implementation
{
    public class ViberProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public ViberProcessor()
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
