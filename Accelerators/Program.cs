// See https://aka.ms/new-console-template for more information
using Accelerators.Processors;
using SMMTool.Utils.WindowsApi;
using System.Diagnostics;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        var winApi = new WinApiWrapper();
        var adobeProcessor = new AdobePdfProcessor(winApi);
        var viberProcessor = new ViberProcessor(winApi);
        var telegramProcessor = new TelegramProcessor(winApi);
        var skypeProcessor = new SkypeProcessor(winApi);
        var chromeProcessor = new ChromeProcessor(winApi);
        var explorerProcessor = new FileExplorerProcessor(winApi);
        var libreProcessor = new LibreOfficeProcessor(winApi);

        while (true)
        {
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

            if (fw != IntPtr.Zero)
            {
                if (fw == explorer)
                {
                    explorerProcessor.Process(explorer);
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