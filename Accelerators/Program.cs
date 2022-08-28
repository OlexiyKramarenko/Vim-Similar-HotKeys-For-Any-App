// See https://aka.ms/new-console-template for more information
using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using SMMTool.Utils.WindowsApi;

public class Program
{

    public static void Main(string[] args)
    {
        var winApi = new WinApiWrapper();

        var processorsDictionary = new Dictionary<IProcessor, Func<IntPtr>>
        {
            { new FileExplorerProcessor(winApi), () => WinApi.FindWindowA("CabinetWClass", null) },
            { new ViberProcessor(winApi), () => WinApi.FindWindowA("Qt624QWindowOwnDCIcon", null) },
            { new TelegramProcessor(winApi), () => WinApi.FindWindowA("Qt5153QWindowIcon", null) },
            { new AdobePdfProcessor(winApi), () => WinApi.FindWindowA("AcrobatSDIWindow", null) },
            { new LibreOfficeProcessor(winApi), () => WinApi.FindWindowA("SALFRAME", null) },
            { new ChromeProcessor(winApi), () => WinApi.GetHwndOfForegroundProcessByName("chrome") },
            { new SkypeProcessor(winApi), () => WinApi.GetHwndOfForegroundProcessByName("skype") }
        };

        while (true)
        {
            var foregroundWindow = WinApi.GetForegroundWindow();

            processorsDictionary
                .Where(kv => kv.Value() != IntPtr.Zero)
                .Where(kv => kv.Value() == foregroundWindow)
                .Select(kv => kv.Key)
                .DefaultIfEmpty(new NullProcessor())
                .Single()
                .Process(foregroundWindow);
        }
    }

}