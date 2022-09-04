using Utils.Window;

namespace Accelerators.Handlers
{
    public class NullHandler : IHandler
    {
        private static NullHandler _nullHandler;

        public static NullHandler Instance
        {
            get
            {
                if (_nullHandler == null)
                {
                    _nullHandler = new NullHandler();
                }

                return _nullHandler;
            }
        }

        private NullHandler()
        {
        }

        public void Handle(WindowGeometry window)
        {
        }

    }
}
