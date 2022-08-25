﻿using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.Handlers.AdobePdfReader
{
    public class ReopenClosedTab : HandlerBase
    {

        public ReopenClosedTab() { }
        public ReopenClosedTab(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.R_key,
            VirtualKey.E_key
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
             .Wait(200)
             .SendKey(VirtualKey.VK_ESCAPE)
             .SendKeyDown(VirtualKey.VK_CONTROL)
             .Wait(100)
             .SendKeyDown(VirtualKey.VK_SHIFT)
             .Wait(100)
             .SendKey(VirtualKey.T_key)
             .Wait(100)
             .SendKeyUp(VirtualKey.VK_SHIFT)
             .SendKeyUp(VirtualKey.VK_CONTROL);

    }
}


