using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class WindowActions : WinApiWrapper
    {

        public WindowActions MovePointer(WindowCoords coords)
        {
            MouseMove(coords.X, coords.Y);
            return this;
        }

        public WindowActions RightClick(WindowCoords func)
        {
            MouseClick(func.X, func.Y, MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP);
            return this;
        }

        public WindowActions LeftClick(WindowCoords func)
        {
            MouseClick(func.X, func.Y, MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);
            return this;
        }

        public WindowActions Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            return this;
        }

        public WindowActions MouseWheel(int distance)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, distance, UIntPtr.Zero);
            return this;
        }

        public WindowActions Press(VirtualKey key, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Press(key);
            }

            return this;
        }

        public WindowActions Press(VirtualKey key)
        {
            KeyDown(key);
            KeyUp(key);
            return this;
        }

        public WindowActions KeysCombination(VirtualKey key1, VirtualKey key2)
        {
            KeyDown(key2);
            Press(key1);
            KeyUp(key2);

            return this;
        }

        public WindowActions Press(VirtualKey key1, VirtualKey key2)
        {
            KeyDown(key1);
            Press(key2);
            KeyUp(key1);

            return this;
        }

        public WindowActions Press(VirtualKey key1, VirtualKey key2, VirtualKey key3)
        {
            KeyDown(key1);
            KeyDown(key2);
            Press(key3);
            KeyUp(key2);
            KeyUp(key1);

            return this;
        }

        private WindowActions KeyDown(VirtualKey key)
        {
            WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, UIntPtr.Zero);
            return this;
        }

        private WindowActions KeyUp(VirtualKey key)
        {
            WinApi.keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
            return this;
        }
    }
}
