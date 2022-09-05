using Accelerators.Processors.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils.Window;

namespace Accelerators.Processors
{
    public static class WindowProcessorHelper
    {

        private static Dictionary<IntPtr, WindowGeometry> WindowObjPool = new Dictionary<IntPtr, WindowGeometry>();

        public static void Process(
            Dictionary<ProcessorBase, Func<IntPtr>> processorsDictionary,
            IntPtr foregroundHwnd)
        {
            AddObjToPool(foregroundHwnd);

            processorsDictionary
                .Where(kv => kv.Value() != IntPtr.Zero)
                .Where(kv => kv.Value() == foregroundHwnd)
                .Select(kv => kv.Key)
                .DefaultIfEmpty(NullProcessor.Instance)
                .Single()
                .Process(WindowObjPool[foregroundHwnd]);
        }


        private static void AddObjToPool(IntPtr hwnd)
        {
            bool poolIsEmptyOrDoesntHaveTheKey =
                        !WindowObjPool.ContainsKey(hwnd) ||
                        !WindowObjPool.Any();

            if (poolIsEmptyOrDoesntHaveTheKey)
            {
                WindowObjPool.Add(hwnd, WindowGeometry.Create(hwnd));
            }
        }

    }
}