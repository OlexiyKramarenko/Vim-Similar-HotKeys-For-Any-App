namespace SMMTool.Utils.WindowsApi
{
    public class Window : WinApiWrapper
    {
        public IntPtr Hwnd { get; }

        private Window(IntPtr hwnd)
        {
            Hwnd = hwnd;
        }

        public static Window Create(IntPtr ptr) => new Window(ptr);

        public int Width => GetWindowRightX(Hwnd) - GetWindowLeftX(Hwnd);
        public int Height => GetWindowBottomY(Hwnd) - GetWindowTopY(Hwnd);
        public int BottomY => GetWindowRect(Hwnd).Bottom;
        public int TopY => GetWindowRect(Hwnd).Top;
        public int LeftX => GetWindowRect(Hwnd).Left;
        public int RightX => GetWindowRect(Hwnd).Right;


        public WindowCoords InCenter()
        {
            var x = GetWindowLeftX(Hwnd);
            var y = GetWindowTopY(Hwnd);

            return new WindowCoords(x + Width / 2, y + Height / 2);
        }

        public WindowCoords InCurrentPosition()
        {
            var pos = GetCursorScreenPosition();

            return new WindowCoords(pos.X, pos.Y);
        }

        public WindowCoords FromBottomLeft(int x, int y)
        {
            return new WindowCoords(
                x: GetWindowLeftX(Hwnd) + x,
                y: GetWindowBottomY(Hwnd) + y);
        }

        public WindowCoords FromBottomRight(int x, int y)
        {
            return new WindowCoords(
                x: GetWindowRightX(Hwnd) + x,
                y: GetWindowBottomY(Hwnd) + y);
        }

        public WindowCoords FromTopRight(int x, int y)
        {
            return new WindowCoords(
                x: GetWindowRightX(Hwnd) + x,
                y: GetWindowTopY(Hwnd) + y);
        }

        public WindowCoords FromTopLeft(int x, int y)
        {
            var dx = GetWindowLeftX(Hwnd);
            var dy = GetWindowTopY(Hwnd);

            return new WindowCoords(x: dx + x, y: dy + y);
        }

        public WindowCoords FromTopLeft()
        {
            var pos = GetCursorScreenPosition();
            var dx = GetWindowLeftX(Hwnd);
            var dy = GetWindowTopY(Hwnd);
            return new WindowCoords(pos.X - LeftX, pos.Y - TopY);
        }

    }
}
