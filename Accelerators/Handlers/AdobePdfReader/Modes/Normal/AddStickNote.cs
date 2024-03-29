﻿using Utils.WinApi;
using Utils.Window;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class AddStickNote : HandlerBase
    {
        public AddStickNote()
        {
        }

        public AddStickNote(IHandler next) : base(next) { }

        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_OEM_6 // "]"
        };

        protected override void SendKeys(WindowGeometry window) => Actions
             .Press(VirtualKey.VK_CONTROL,
                    VirtualKey.VK_LEFT)
             .Wait(100)
             .Press(VirtualKey.VK_CONTROL,
                    VirtualKey.VK_SHIFT,
                    VirtualKey.VK_RIGHT)
             .Wait(100)
             .Press(VirtualKey.VK_SHIFT,
                    VirtualKey.VK_F10)
             .Wait(100)
             .Press(VirtualKey.VK_DOWN, times: 5)
             .Press(VirtualKey.VK_RETURN);

    }
}


