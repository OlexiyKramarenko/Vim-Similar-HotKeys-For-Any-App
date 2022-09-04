using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using SMMTool.Utils.WindowsApi;

namespace Accelerators
{
    public class Program
    {

        private static Dictionary<ProcessorBase, Func<IntPtr>> ProcessorsDictionary
        { get; } = new Dictionary<ProcessorBase, Func<IntPtr>>
        {
            { new FileExplorerProcessor(new WindowActions()), () => WinApi.FindWindowA("CabinetWClass", null) },
            { new ViberProcessor(), () => WinApi.FindWindowA("Qt624QWindowOwnDCIcon", null) },
            { new TelegramProcessor(), () => WinApi.FindWindowA("Qt5154QWindowIcon", null) },
            { new AdobePdfProcessor(), () => WinApi.FindWindowA("AcrobatSDIWindow", null) },
            { new LibreOfficeProcessor(), () => WinApi.FindWindowA("SALFRAME", null) },
            { new ChromeProcessor(), () => WinApi.GetHwndOfForegroundProcessByName("chrome") },
            { new SkypeProcessor(), () => WinApi.GetHwndOfForegroundProcessByName("skype") }
        };


        public static void Main(string[] args)
        {
            while (true)
            {
                var foregroundHwnd = WinApi.GetForegroundWindow();

                WindowProcessorHelper.Process(ProcessorsDictionary, foregroundHwnd);
            }
        }

    }
}