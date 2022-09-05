using Accelerators.Handlers;
using Accelerators.Handlers.Skype.Modes.Normal;
using Accelerators.Modes.Implementation;
using System;
using System.Collections.Generic;

namespace Accelerators.Processors.Implementation
{
    public class SkypeProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public SkypeProcessor()
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(NormalState),
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
                                        new Maximize())))))))))) }
            };
        }
    }
}
