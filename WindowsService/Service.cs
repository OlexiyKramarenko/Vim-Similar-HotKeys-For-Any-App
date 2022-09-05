using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading.Tasks;
using Utils.Window;

namespace WindowsService
{
    public partial class Service : ServiceBase
    {

        private bool _cancelProcessing;

        private Dictionary<ProcessorBase, Func<IntPtr>> _processorsDictionary = new Dictionary<ProcessorBase, Func<IntPtr>>
        {
            { new FileExplorerProcessor(), () => WindowActions.GetWindowHandle("CabinetWClass") },
            { new ViberProcessor(), () => WindowActions.GetWindowHandle("Qt624QWindowOwnDCIcon") },
            { new TelegramProcessor(), () => WindowActions.GetWindowHandle("Qt5154QWindowIcon") },
            { new AdobePdfProcessor(), () => WindowActions.GetWindowHandle("AcrobatSDIWindow") },
            { new LibreOfficeProcessor(), () => WindowActions.GetWindowHandle("SALFRAME") },
            { new ChromeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("chrome") },
            { new SkypeProcessor(), () => WindowActions.GetHandleOfForegroundProcess("skype") }
        };

        public Service()
        {
            InitializeComponent();

            _cancelProcessing = false;
        }

        protected override void OnStart(string[] args)
        {
            Task.Run(() => Processing(_processorsDictionary));

            EventLog.WriteEntry("HotKeys started.");
        }

        protected override void OnStop()
        {
            _cancelProcessing = true;
            EventLog.WriteEntry("HotKeys stopped.");
        }

        private void Processing(Dictionary<ProcessorBase, Func<IntPtr>> processorsDictionary)
        {
            while (_cancelProcessing)
            {
                WindowProcessorHelper.Process(
                                        processorsDictionary,
                                        WindowActions.ForegroundWindowHandle);
            }
        }

    }
}
