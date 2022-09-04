using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using Utils.Window;

namespace Accelerators
{
    public class Program
    {
        private static readonly Dictionary<ProcessorBase, Func<IntPtr>> _processorsDictionary;

        static Program()
        { 
            _processorsDictionary = new Dictionary<ProcessorBase, Func<IntPtr>>
            {
                { new FileExplorerProcessor(), () => WindowActions.GetWindowHandle("CabinetWClass") },
                { new ViberProcessor(), () => WindowActions.GetWindowHandle("Qt624QWindowOwnDCIcon") },
                { new TelegramProcessor(), () => WindowActions.GetWindowHandle("Qt5154QWindowIcon") },
                { new AdobePdfProcessor(), () => WindowActions.GetWindowHandle("AcrobatSDIWindow") },
                { new LibreOfficeProcessor(), () => WindowActions.GetWindowHandle("SALFRAME") },
                { new ChromeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("chrome") },
                { new SkypeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("skype") }
            };
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                WindowProcessorHelper.Process(
                                        _processorsDictionary,
                                        WindowActions.ForegroundWindowHandle);
            }
        }

    }
}