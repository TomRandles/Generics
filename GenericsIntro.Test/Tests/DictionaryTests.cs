using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void CanUseDictionaryAsMap()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");
            
            Assert.AreEqual("one", map[1]);
        }

        [TestMethod]
        public void CanSearchKeyWithContainsKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.IsTrue(map.ContainsKey(2));
        }

        [TestMethod]
        public void CanRemoveByKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            map.Remove(1);

            Assert.AreEqual(1, map.Count);
        }   
    }
}
