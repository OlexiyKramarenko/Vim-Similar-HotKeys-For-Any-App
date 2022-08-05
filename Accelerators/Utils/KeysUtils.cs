using static Accelerators.Utils.WinApi;

namespace Accelerators.Utils
{
    public class KeysUtils
    {
        public void SendKey(VirtualKeyStates key)
        {
            SendKeyDown(key);
            SendKeyUp(key);
        }

        public void SendKeyDown(VirtualKeyStates key) =>
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, UIntPtr.Zero);


        public void SendKeyUp(VirtualKeyStates key) =>
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);

        public bool KeyIsPressed(VirtualKeyStates key) => (GetAsyncKeyState((int)key) & 0x8000) != 0;

        public bool KeysArePressed(VirtualKeyStates key1, VirtualKeyStates key2) =>
            KeyIsPressed(key1) && KeyIsPressed(key2);

        public bool KeysArePressed(VirtualKeyStates key1, VirtualKeyStates key2, VirtualKeyStates key3) => 
            KeysArePressed(key1, key2) && KeyIsPressed(key3);

        //public bool KeyIsPressed(VirtualKeyStates key) => (GetAsyncKeyState((int)key) & 0x8000) != 0;


        private DateTime PrevDataTime = DateTime.MinValue;

        public void OnKeyPressedTwice(
            VirtualKeyStates onKey,
            Action<VirtualKeyStates> action,
            VirtualKeyStates virtualKey)
        {
            if (KeyIsPressed(onKey))
            {
                if (PrevDataTime == DateTime.MinValue)
                {
                    PrevDataTime = DateTime.Now;
                    return;
                }

                int intervalBetweenTwoPresses = (DateTime.Now - PrevDataTime).Seconds;

                if (intervalBetweenTwoPresses <= 1.1)
                {
                    action(virtualKey);
                }

                PrevDataTime = DateTime.MinValue;
            }
        }

    }
}
