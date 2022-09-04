using Accelerators.Modes.Implementation;

namespace Accelerators.Modes
{
    public class ModeContext
    {
        public IState State;

        public string ModeName => State.Name;

        public ModeContext()
        {
            State = new NormalState();
        }

        public void UpdateState(IState state)
        {
            State = state;
        }
    }
}
