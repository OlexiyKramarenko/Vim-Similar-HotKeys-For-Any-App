using Accelerators.Handlers;
using Accelerators.Modes;
using SMMTool.Utils.WindowsApi;

namespace Accelerators.Processors.Implementation
{
    public class NullProcessor : ProcessorBase
    {
        private static NullProcessor _nullProcessor;

        private NullProcessor() : base(new WindowActions(), new ModeContext()) { }

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
