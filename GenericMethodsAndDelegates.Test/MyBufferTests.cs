using GenericMethodsAndDelegates.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericMethodsAndDelegates.Test
{
    [TestClass]
    public class MyBufferTests
    {
        [TestMethod]
        public void BufferIsEmpty()
        {
            var buffer = new MyQueueBuffer<double>();
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void BufferIsFull()
        {
            var buffer = new CappedQueueBuffer<double>(capacity: 3);
            buffer.Write(1);
            buffer.Write(1);
            buffer.Write(1);
            Assert.IsTrue(buffer.IsFull);
        }

        [TestMethod]
        public void FirstInFirstOut()
        {
            var buffer = new CappedQueueBuffer<string>(capacity: 3);
            var value1 = "1.1";
            var value2 = "2.0";

            buffer.Write(value1);
            buffer.Write(value2);

            Assert.AreEqual(value1, buffer.Read());
            Assert.AreEqual(value2, buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void Overwrites_When_More_Than_Capacity()
        {
            var buffer = new CappedQueueBuffer<double>(capacity: 3);
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
