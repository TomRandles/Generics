using GenericsIntro.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsIntro.Tests
{

    [TestClass]
    public class BufferTests
    {
        [TestMethod]
        public void CheckBufferIsEmpty()
        {
            var buffer = new MyBuffer<double>();

            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void CheckBufferIsFull()
        {
            var buffer = new MyBuffer<double>(capacity: 3);
            buffer.Write(1.5);
            buffer.Write(1.5);
            buffer.Write(1.5);

            Assert.IsTrue(buffer.IsFull);
        }

        [TestMethod]
        public void FirstInFirstOutWithinCapacity()
        {
            var buffer = new MyBuffer<string>(capacity: 3);
            var value1 = "1.1";
            var value2 = "2.0";

            buffer.Write(value1);
            buffer.Write(value2);

            Assert.AreEqual(value1, buffer.Read());
            Assert.AreEqual(value2, buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void OverwritesWhenCapacityExceeded()
        {
            var buffer = new MyBuffer<double>(capacity: 3);
            var values = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            foreach (var value in values)
            {
                buffer.Write(value);
            }

            Assert.IsTrue(buffer.IsFull);
            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[3], buffer.Read());
            Assert.AreEqual(values[4], buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}
