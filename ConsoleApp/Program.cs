using Accelerators.Processors;
using Accelerators.Processors.POCO;
using Accelerators.Processors.POCO.Implementation;
using Accelerators.Processors.Implementation;
using System.Collections.Generic;
using Utils.Window;

namespace ConsoleApp
{
    class Program
    {
        private static readonly IEnumerable<ProcessorHandle> _processorHandleList =
            new List<ProcessorHandle>
            {
                new ProcessorHandle(new FileExplorerProcessor(), new WndClass("CabinetWClass")),
                new ProcessorHandle(new ViberProcessor(), new WndClass("Qt624QWindowOwnDCIcon")),
                new ProcessorHandle(new TelegramProcessor(), new WndClass("Qt5154QWindowIcon")),
                new ProcessorHandle(new AdobePdfProcessor(), new WndClass("AcrobatSDIWindow")),
                new ProcessorHandle(new LibreOfficeProcessor(), new WndClass("SALFRAME")),
                new ProcessorHandle(new ChromeProcessor(), new ProcessName("chrome")),
                new ProcessorHandle(new SkypeProcessor(), new ProcessName("skype")),
            };

        static void Main(string[] args)
        {
            Processing(_processorHandleList);
        }

        private static void Processing(IEnumerable<ProcessorHandle> processorsDictionary)
        {
            while (true)
            {
                WindowProcessorHelper.Process(
                                        processorsDictionary,
                                        WindowActions.ForegroundWindowHandle);
            }
        }
    }
}
