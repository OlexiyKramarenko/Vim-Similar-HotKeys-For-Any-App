using Accelerators.Processors;
using Accelerators.Processors.POCO;
using Accelerators.Processors.POCO.Implementation;
using Accelerators.Processors.Implementation;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading.Tasks;
using Utils.Window;

namespace WindowsService
{
    public partial class Service : ServiceBase
    {

        private bool _cancel;

        private readonly IEnumerable<ProcessorHandle> _processorHandleList =
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

        public Service()
        {
            InitializeComponent();

            _cancel = false;
        }

        protected override void OnStart(string[] args)
        {
            Task.Run(() => Processing(_processorHandleList));

            EventLog.WriteEntry("HotKeys started.");
        }

        protected override void OnStop()
        {
            _cancel = true;

            EventLog.WriteEntry("HotKeys stopped.");
        }

        private void Processing(IEnumerable<ProcessorHandle> processorHandleList)
        {
            while (_cancel)
            {
                WindowProcessorHelper.Process(
                                        processorHandleList,
                                        WindowActions.ForegroundWindowHandle);
            }
        }

    }
}
