using System;
using Utils.Window;

namespace Accelerators.Processors.POCO.Implementation
{
    public class ProcessName : IHandle
    {
        public string Name { get; }

        public ProcessName(string name)
        {
            Name = name;
        }

        public IntPtr Value => WindowActions.GetHandleOfForegroundProcess(Name);
    }
}