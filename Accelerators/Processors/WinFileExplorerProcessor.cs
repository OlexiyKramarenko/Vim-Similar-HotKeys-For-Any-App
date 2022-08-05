using Accelerators.Utils;
using static Accelerators.Utils.WinApi;

namespace Accelerators.Processors
{
    public class WinFileExplorerProcessor
    {
        private bool InsertMode;
        private bool FindMode;
        private bool NormalMode;
        private bool VisualMode;


        private readonly KeysUtils u;

        public WinFileExplorerProcessor(KeysUtils utils)
        {
            u = utils;
        }

        private enum Mode
        {
            Find, Insert, Normal, Visual
        }

        void DisplayTooltip(string text)
        {

        }

        public void ChangeMode()
        {
            if (u.KeyIsPressed(VirtualKeyStates.A_key))
            {
                DisplayTooltip("NormalMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.A_key))
            {
                DisplayTooltip("VisualMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.A_key))
            {
                DisplayTooltip("InsertMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.A_key))
            {
                DisplayTooltip("FindMode");
            }
        }

        //Show tooltip
        void ExplorerToggleInsert()
        {
        }


        public void Process(IntPtr hwnd)
        {
            IntPtr hInstance = System.Diagnostics.Process.GetProcessesByName("explorer").First().Handle;//  GetCurrentProcess(); 

            IntPtr hwndTip = CreateWindowEx(
          0,
          "MyClass", // window caption
          "MyWindow", // window caption
          WindowStyles.WS_POPUP | WindowStyles.TTS_ALWAYSTIP | WindowStyles.TTS_BALLOON, // window style
          0, // initial x position
          0, // initial y position
          500, // initial x size
          500, // initial y size
          GetParent(hwnd),  // window menu handle
          IntPtr.Zero,
          hInstance, //        !!!!!!!   hInstance, // program instance handle
          IntPtr.Zero); // creation parameters

            var tinfo = new TOOLINFO();
            tinfo.hwnd = hwnd;
            tinfo.uFlags = 0x0001 | 0x0010;
            tinfo.uId = hwnd;
            tinfo.lpszText = "111";

           var  TTM_ACTIVATE = WinApi.WM_USER + 1;

            SendMessage(hwndTip, TTM_ACTIVATE, 1, 0);
            //SendMessage(hwndTip, TTM_ADDTOOL, 0, (LPARAM) & toolInfo)
            if (FindMode)
            {

            }

            if (InsertMode)
            {

            }

            if (NormalMode)
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }

            if (u.KeyIsPressed(VirtualKeyStates.H_key))
            {

            }
        }
    }
}
