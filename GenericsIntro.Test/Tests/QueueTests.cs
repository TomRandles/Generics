using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void CanPeekAtNextItem()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void CanSearchWithContains()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.IsTrue(queue.Contains(2));
        }

        [TestMethod]
        public void CanConvertQueueToArray()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var asArray = queue.ToArray();
            queue.Dequeue();

            Assert.AreEqual(1, asArray[0]);
            Assert.AreEqual(2, queue.Count);
        }   
    }
}
