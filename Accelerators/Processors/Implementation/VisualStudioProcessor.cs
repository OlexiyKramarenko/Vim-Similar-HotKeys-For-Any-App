using Accelerators.Handlers;
using Accelerators.Handlers.VisualStudio.Modes.Normal;
using Accelerators.Modes.Implementation;
using System;
using System.Collections.Generic;

namespace Accelerators.Processors.Implementation
{
    public class VisualStudioProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public VisualStudioProcessor()
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                { typeof(NormalState),
                                new MoveWindow(
                                 new Minimize(
                                  new Size())) },
            };
        }
    }
}
