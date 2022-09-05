using System;

namespace Accelerators.Processors.POCO
{
    public class ProcessorHandle
    {
        public ProcessorBase Processor { get; }
        public IHandle Handle { get; }

        public ProcessorHandle(ProcessorBase processor, IHandle handle)
        {
            Processor = processor;
            Handle = handle;
        }

        public IntPtr GetHandle()
        {
            return Handle.Value;
        }
    }
}