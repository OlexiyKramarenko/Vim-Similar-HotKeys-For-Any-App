// See https://aka.ms/new-console-template for more information
using Accelerators.Processors;
using Accelerators.Utils;
using System.Drawing;

Console.WriteLine("Hello, World!");

var adobeProcessor = new AdobePdfProcessor(new KeysUtils());
var viberProcessor = new ViberProcessor(new KeysUtils());
var telegramProcessor = new TelegramProcessor(new KeysUtils());
var skypeProcessor = new SkypeProcessor(new KeysUtils());
var chromeProcessor = new ChromeProcessor(new KeysUtils());
var explorerProcessor = new WinFileExplorerProcessor(new KeysUtils());
var libreProcessor = new LibreOfficeProcessor(new KeysUtils());


//var skype = WinApi.FindWindowA("Chrome_WidgetWin_1", null);
//var bounds = new Rectangle(0, 0, 300, 300);
//var m_ttip = new BalloonToolTip(skype, bounds);

BalloonToolTip m_ttip = null;

while (true)
{
    Thread.Sleep(200);
    var mpc = WinApi.FindWindowA("MediaPlayerClassicW", null);
    var explorer = WinApi.FindWindowA("CabinetWClass", null);
    var viber = WinApi.FindWindowA("Qt624QWindowOwnDCIcon", null);
    var skype = WinApi.FindWindowA("Chrome_WidgetWin_1", null);
    var telegram = WinApi.FindWindowA("Qt5153QWindowIcon", null);
    var adobe = WinApi.FindWindowA("AcrobatSDIWindow", null);
    var wps = WinApi.FindWindowA("OpusApp", null);
    var chrome = WinApi.FindWindowA("Intermediate D3D Window", null);
    var libre = WinApi.FindWindowA("SALFRAME", null);

    var fw = WinApi.GetForegroundWindow();

    if (m_ttip == null)
    {
        var bounds = new Rectangle(0, 0, 300, 300);
        m_ttip = new BalloonToolTip(skype, bounds);
        //m_ttip.strTitle = "Balloon #1";
        //m_ttip.iconResult = ToolTipIcon.Info;

        m_ttip.Create();
    }

    if (fw == adobe)
    {
        adobeProcessor.Process(adobe);
    }

    if (fw == viber)
    {
        viberProcessor.Process(viber);

        m_ttip.strText = "DD"; 
        m_ttip.Show(new Point(0, 0));
    }

    if (fw == telegram)
    {
        telegramProcessor.Process(telegram);

        m_ttip.strText = "CC"; 
        m_ttip.Show(new Point(0, 0));
    }

    if (fw == chrome)
    {
        chromeProcessor.Process(chrome); 
        
        //m_ttip.strText = "CC";
        ////m_ttip.strText == "NORMAL" ? "VISUAL" : "NORMAL";

        //m_ttip.Show(new Point(0, 0));

        ////m_ttip.Hide();
        ////m_ttip.strText = "VISUAL"; 
        ////m_ttip.Show(new Point(0, 0));
    }

    if (fw == explorer)
    {
        explorerProcessor.Process(explorer); 
        
        m_ttip.strText = "BB"; 
        m_ttip.Show(new Point(0, 0));
    }

    if (fw == libre)
    {
        libreProcessor.Process(chrome);
    }



    if (fw == skype)
    {
        skypeProcessor.Process(skype);

        m_ttip.strText = "AA"; 
        m_ttip.Show(new Point(0, 0));
    }
    //else
    //{
    //    m_ttip.Hide();
    //}

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