using Accelerators.Processors;
using Accelerators.Processors.Implementation;
using SMMTool.Utils.WindowsApi;

namespace Accelerators
{
    public static class WindowProcessorHelper
    {

        private static Dictionary<IntPtr, Window> WindowObjPool = new Dictionary<IntPtr, Window>();

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
                WindowObjPool.Add(hwnd, Window.Create(hwnd));
            }
        }

    }
}