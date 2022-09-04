using static SMMTool.Utils.WindowsApi.WinApi;

namespace SMMTool.Utils.WindowsApi
{
    public class WindowCoords : WinApiWrapper
    {

        public int X { get; }
        public int Y { get; }

        public WindowCoords()
        {

        }

        public WindowCoords(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public WindowActions LeftClick()
        //{
        //    MouseClick(X, Y, MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP);

        //    return new WindowActions();
        //}

        //public WindowActions RightClick()
        //{
        //    MouseClick(X, Y, MOUSEEVENTF_RIGHTDOWN, MOUSEEVENTF_RIGHTUP);

        //    return new WindowActions();
        //}

        //public WindowActions GetPointerPosition()
        //{
        //    POINT res = GetCursorScreenPosition();

        //    return new WindowActions();
        //}

    }
}
