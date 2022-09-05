using Accelerators.Handlers;
using System;
using System.Collections.Generic;

namespace Accelerators.Processors.Implementation
{
    public class NullProcessor : ProcessorBase
    {
        private static NullProcessor _nullProcessor;

        private NullProcessor() { }

        public static NullProcessor Instance
        {
            get
            {
                if (_nullProcessor == null)
                    _nullProcessor = new NullProcessor();

                return _nullProcessor;
            }
        }

        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary =>
            new Dictionary<Type, HandlerBase>();
    }
}
