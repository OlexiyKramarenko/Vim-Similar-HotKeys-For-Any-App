using SMMTool.Utils.WindowsApi;

namespace Utils
{
    public class WinApiFactory
    {
        public WinApiWrapper Create()
        {
            return new WinApiWrapper();
        }
    }
}
