using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GenericsIntro.Domain;

namespace GenericsIntro.Test.Tests
{
    [TestClass]
    public class MyBufferTests
    {
        [TestMethod]
        public void EmptyBufferTest()
        {
            var buffer = new MyBuffer<double>();
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void BufferFullAfterThreeWrites()
        {
            var buffer = new MyBuffer<double>(capacity:3);
            buffer.Write(5.0);
            buffer.Write(6.0);
            buffer.Write(7.0);
            Assert.IsTrue(buffer.IsFull);
        }

        [TestMethod]
        public void FirstInFirstOut()
        {
            var buffer = new MyBuffer<double>(capacity: 3);
            buffer.Write(5.0);
            buffer.Write(8.0);
            var readVal1 = buffer.Read();
            var readVal2 = buffer.Read();
            Assert.AreEqual(5.0, readVal1);
            Assert.AreEqual(8.0, readVal2);
        }

        [TestMethod]
        public void OverWrites()
        {
            var buffer = new MyBuffer<double>(capacity: 3);
            var testArray = new [] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            foreach (var val in testArray)
            {
                buffer.Write(val);
            }
            Assert.IsTrue(buffer.IsFull);
            Assert.AreEqual(testArray[2], buffer.Read());
            Assert.AreEqual(testArray[3], buffer.Read());
            Assert.AreEqual(testArray[4], buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}