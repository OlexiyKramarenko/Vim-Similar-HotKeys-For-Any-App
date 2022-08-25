namespace Accelerators.Handlers.FileExplorer.Modes
{
    public class ModeContext
    {

        private static ModeContext _context;

        public static ModeContext Instance
        {
            get
            {
                if (_context == null)
                    _context = new ModeContext();

                return _context;
            }
        }

        private IState _state;

        public string ModeName => _state.Name;

        public ModeContext()
        {
            _state = new NormalState();
        }

        public void UpdateState(IState state)
        {
            _state = state;
        }

    }
}
