using System.Collections.Concurrent;


namespace DeveloperSample.Syncing
{
    public class SyncDebug
    {
        public List<string> InitializeList(IEnumerable<string> items)
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            List<Task> bagAddTasks = new List<Task>();
            Parallel.ForEach(items, i =>
            {
                bagAddTasks.Add(Task.Run(() => bag.Add(i)));
            });
            // Wait for all tasks to complete
            Task.WaitAll(bagAddTasks.ToArray());
            var list = bag.ToList();
            return list;
        }

        public async Task<Dictionary<int, string>> InitializeDictionary(Func<int, string> getItem)
        {
            var concurrentDictionary = new ConcurrentDictionary<int, string>();
            await Task.WhenAll(Task.Run(() => TryAddDictionary(getItem, concurrentDictionary)));
            return concurrentDictionary.ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        private void TryAddDictionary(Func<int, string> getItem, ConcurrentDictionary<int, string> concurrentDictionary)
        {

            var itemsToInitialize = Enumerable.Range(0, 100).ToList();
            for (var i = 0; i < itemsToInitialize.Count; ++i)
            {
                var res = concurrentDictionary.AddOrUpdate(i, getItem, (_, s) => s);
                var (item, threadId) = (i, Thread.CurrentThread.ManagedThreadId);
                concurrentDictionary.AddOrUpdate(item, getItem, (_, s) => s);
            }
        }
    }
}
   