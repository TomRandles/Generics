using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void CanAddAfter()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.AddAfter(list.First, "there");

            Assert.AreEqual("there", list.First.Next.Value);
        }

        [TestMethod]
        public void CanRemoveLast()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.RemoveLast();            
            
            Assert.AreEqual(list.First, list.Last);
        }

        [TestMethod]
        public void CanFindItems()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");

            Assert.IsTrue(list.Contains("Hello"));
        }
    }
}
