using GenericsIntro.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace GenericsIntro.Tests
{

    [TestClass]
    public class BufferTests
    {
        [TestMethod]
        public void CheckBufferIsEmpty()
        {
            var buffer = new Buffer<double>();

            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void CheckBufferIsFull()
        {
            var buffer = new Buffer<double>(capacity: 3);
            buffer.Write(1.5);
            buffer.Write(1.5);
            buffer.Write(1.5);

            Assert.IsTrue(buffer.IsFull);
        }
    }
}
