using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class TwiceKeyPressHandler
    {
        private DateTime PrevDataTime = DateTime.MinValue;

        private readonly WinApiWrapper _winApiWrapper;

        public TwiceKeyPressHandler(WinApiWrapper winApiWrapper)
        {
            _winApiWrapper = winApiWrapper;
        } 

        public void OnKeyPressedTwice(
                            VirtualKeyStates onKey,
                            Func<VirtualKeyStates, WinApiWrapper> func,
                            VirtualKeyStates virtualKey)
        {
            if (_winApiWrapper.KeyIsPressed(onKey))
            {
                if (PrevDataTime == DateTime.MinValue)
                {
                    PrevDataTime = DateTime.Now;
                    return;
                }

                int intervalBetweenTwoPresses = (DateTime.Now - PrevDataTime).Seconds;

                if (intervalBetweenTwoPresses <= 1.18)
                {
                    func(virtualKey);
                }

                PrevDataTime = DateTime.MinValue;
            }
        }
    }
}
