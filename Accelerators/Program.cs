// See https://aka.ms/new-console-template for more information
using Accelerators.Processors;
using SMMTool.Utils.WindowsApi;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        var adobeProcessor = new AdobePdfProcessor(new WinApiWrapper(), new TwiceKeyPressHandler(new WinApiWrapper()));
        var viberProcessor = new ViberProcessor(new WinApiWrapper());
        var telegramProcessor = new TelegramProcessor(new WinApiWrapper());
        var skypeProcessor = new SkypeProcessor(new WinApiWrapper());
        var chromeProcessor = new ChromeProcessor(new WinApiWrapper());
        var explorerProcessor = new WinFileExplorerProcessor(new WinApiWrapper());
        var libreProcessor = new LibreOfficeProcessor(new WinApiWrapper());

        ToolTip m_ttip = null;

        while (true)
        {
            //Thread.Sleep(100);
            var mpc = WinApi.FindWindowA("MediaPlayerClassicW", null);
            var explorer = WinApi.FindWindowA("CabinetWClass", null);
            var viber = WinApi.FindWindowA("Qt624QWindowOwnDCIcon", null);
            var telegram = WinApi.FindWindowA("Qt5153QWindowIcon", null);
            var adobe = WinApi.FindWindowA("AcrobatSDIWindow", null);
            var wps = WinApi.FindWindowA("OpusApp", null);
            var libre = WinApi.FindWindowA("SALFRAME", null);
            var chrome = Get("chrome"); // WinApi.FindWindowA("Chrome_WIdgetWin_1", null);
            var skype = Get("skype");

            IntPtr fw = WinApi.GetForegroundWindow();

            // = new BalloonToolTip(skype, new Rectangle(0, 0, 300, 300)); 

            if (fw != IntPtr.Zero)
            {

                if (fw == explorer)
                {
                    if (m_ttip == null)
                    {
                        m_ttip = new ToolTip(skype, new Rectangle(0, 0, 300, 300));
                        m_ttip.Create();
                        //m_ttip.strText = "BB"; 
                        //var x = new WinApiWrapper().GetWindowLeftX(explorer);
                        //var y = new WinApiWrapper().GetWindowBottomY(explorer); 
                        //m_ttip.Show(new Point(x + 5, y - 6)); 
                        //explorerProcessor.SetTooltip(m_ttip);
                    }

                    var x = new WinApiWrapper().GetWindowLeftX(explorer);
                    var y = new WinApiWrapper().GetWindowBottomY(explorer); 
                    m_ttip.Show(new Point(x + 5, y - 6)); 
                    explorerProcessor.SetTooltip(m_ttip);
                    explorerProcessor.Process(explorer);
                }
                else if (m_ttip != null)
                {
                    m_ttip.Destroy();
                    m_ttip = null;
                }

                if (fw == adobe)
                {
                    adobeProcessor.Process(adobe);
                }

                if (fw == viber)
                {
                    viberProcessor.Process(viber);
                }

                if (fw == telegram)
                {
                    telegramProcessor.Process(telegram);
                }

                if (fw == chrome)
                {
                    chromeProcessor.Process(chrome);
                }

                if (fw == libre)
                {
                    libreProcessor.Process(libre);
                }

                if (fw == skype)
                {
                    skypeProcessor.Process(skype);
                }
            }
        }
    }

    struct TooltipInfo
    {
        public readonly string title;
        public readonly ToolTipIcon icon;
        public readonly string message;

        public TooltipInfo(string _title, ToolTipIcon _icon, string _message)
        {
            title = _title;
            icon = _icon;
            message = _message;
        }
    }
    //readonly Dictionary<Control, TooltipInfo> m_ttipMessages;




    public static IntPtr Get(string name)
    {
        IntPtr hWndChrome = IntPtr.Zero;
        Process[] processes = Process.GetProcessesByName(name);
        if (processes.Length > 0)
        {
            foreach (Process proc in processes)
            {
                if (proc.MainWindowHandle == IntPtr.Zero)
                    continue;
                else
                {
                    hWndChrome = proc.MainWindowHandle;
                    break;
                }
            }
        }
        return hWndChrome;
    }

}