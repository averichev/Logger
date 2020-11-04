using System;

namespace Logger.Application.Memory
{
    public static class MemoryGetter
    {
        public static long GetBytes()
        {
            var memory = GC.GetTotalMemory(true);
            return memory;
        }
    }
}