using DeveloperSample.Syncing;
using Xunit;

namespace ProjectSampleTest
{
    public class SyncTest
    {
        [Fact]
        public void CanInitializeCollection()
        {
            var debug = new SyncDebug();
            var items = new List<string> { "one", "two" };
            var result = debug.InitializeList(items);
            Assert.Equal(items.Count, result.Count);
        }

        [Fact]
        public async Task ItemsOnlyInitializeOnce()
        {
            var debug = new SyncDebug();
            var count = 0;
            var dictionary = await debug.InitializeDictionary(i =>
            {
                Thread.Sleep(1);
                Interlocked.Increment(ref count);
                return i.ToString();
            });

            Assert.Equal(100, count);
            Assert.Equal(100, dictionary.Count);
        }
    }
}

