using Utils.WinApi;
using Utils.Window;

namespace Utils.Handlers
{
    public class DoubleKeyPressHandler
    {

        private DateTime _prevDataTime;

        private VirtualKey _prevKey;

        public void Handle(Action<WindowGeometry> sendKeys, WindowGeometry wnd, VirtualKey key)
        {
            int intervalBetweenTwoPresses =
                (DateTime.Now - _prevDataTime).Milliseconds;

            if (intervalBetweenTwoPresses > 100 &&
                intervalBetweenTwoPresses < 250 &&
                _prevKey == key)
            {
                sendKeys(wnd);
                _prevDataTime = DateTime.MinValue;
                _prevKey = VirtualKey.Undefined_key;
            }
            else
            {
                _prevDataTime = DateTime.Now;
                _prevKey = key;
            }
        }

    }
}
