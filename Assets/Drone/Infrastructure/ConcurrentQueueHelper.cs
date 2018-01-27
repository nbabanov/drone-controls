/*using System.Collections.Concurrent;

namespace Drone.Infrastructure
{
    public static class ConcurrentQueueExtensions
    {
        public static void Flush<T>(this System.Collections.Concurrent.ConcurrentQueue<T> queue)
        {
            T item;
            while (queue.TryDequeue(out item))
            {
            }
        }
    }
}*/