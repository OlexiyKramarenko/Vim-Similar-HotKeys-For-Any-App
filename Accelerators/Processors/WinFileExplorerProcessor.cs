using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Processors
{
    public class WinFileExplorerProcessor
    {
        private ToolTip _toolTip;

        Mode mode = Mode.Normal;

        private readonly WinApiWrapper u;

        public WinFileExplorerProcessor(WinApiWrapper utils)
        {
            u = utils;
        }

        private enum Mode
        {
            Find, Insert, Normal, Visual
        }

        public void SetTooltip(ToolTip m_ttip)
        {
            _toolTip = m_ttip;
        }

        void DisplayTooltip(string text)
        {
            _toolTip.strText = text;
        }

        public void UpdateMode()
        {
            if (u.KeyIsPressed(VirtualKeyStates.A_key))
            {
                mode = Mode.Normal;
                DisplayTooltip("NormalMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.B_key))
            {
                mode = Mode.Visual;
                DisplayTooltip("VisualMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.C_key))
            {
                mode = Mode.Insert;
                DisplayTooltip("InsertMode");
            }

            if (u.KeyIsPressed(VirtualKeyStates.D_key))
            {
                mode = Mode.Find;
                DisplayTooltip("FindMode");
            }
        }


        public void Process(IntPtr hwnd)
        {
            UpdateMode();

            if (mode == Mode.Find)
            {
                //if (u.KeyIsPressed(VirtualKeyStates.D_key))
                //{
                //    mode = Mode.Find;
                //    DisplayTooltip("FindMode");
                //}
            }

            if (mode == Mode.Insert)
            {

            }


            if (mode == Mode.Normal)
            {

            }

            if (mode == Mode.Visual)
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
