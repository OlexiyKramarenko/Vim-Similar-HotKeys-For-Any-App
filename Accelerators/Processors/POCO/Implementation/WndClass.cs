using System;
using Utils.Window;

namespace Accelerators.Processors.POCO.Implementation
{
    public class WndClass : IHandle
    {
        public string Name { get; }

        public WndClass(string name)
        {
            Name = name;
        }

        public IntPtr Value => WindowActions.GetWindowHandleByClassName(Name);
    }
}