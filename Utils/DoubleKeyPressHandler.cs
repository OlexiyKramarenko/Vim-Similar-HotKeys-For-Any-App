using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class DoubleKeyPressHandler
    {

        private DateTime _prevDataTime;

        private VirtualKey _prevKey;

        public void Handle(Action<Window> sendKeys, Window wnd, VirtualKey key)
        {
            int intervalBetweenTwoPresses =
                (DateTime.Now - _prevDataTime).Milliseconds;

            if (intervalBetweenTwoPresses >= 100 &&
                intervalBetweenTwoPresses < 250 &&
                _prevKey == key)
            {
                sendKeys(wnd);
                _prevDataTime = DateTime.MinValue;
                _prevKey = VirtualKey.VK_ZOOM;
            }
            else
            {
                _prevDataTime = DateTime.Now;
                _prevKey = key;
            }
        }

    }
}
