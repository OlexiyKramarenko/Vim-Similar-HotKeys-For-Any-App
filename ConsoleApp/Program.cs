using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using System;
using System.Collections.Generic;
using Utils.Window;

namespace ConsoleApp
{
    class Program
    {
        private static readonly Dictionary<ProcessorBase, Func<IntPtr>> _processorsDictionary =
            new Dictionary<ProcessorBase, Func<IntPtr>>
            {
                { new FileExplorerProcessor(), () => WindowActions.GetWindowHandle("CabinetWClass") },
                { new ViberProcessor(), () => WindowActions.GetWindowHandle("Qt624QWindowOwnDCIcon") },
                { new TelegramProcessor(), () => WindowActions.GetWindowHandle("Qt5154QWindowIcon") },
                { new AdobePdfProcessor(), () => WindowActions.GetWindowHandle("AcrobatSDIWindow") },
                { new LibreOfficeProcessor(), () => WindowActions.GetWindowHandle("SALFRAME") },
                { new ChromeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("chrome") },
                { new SkypeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("skype") }
            };

        static void Main(string[] args)
        {
            Processing(_processorsDictionary);
        }

        private static void Processing(Dictionary<ProcessorBase, Func<IntPtr>> processorsDictionary)
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
