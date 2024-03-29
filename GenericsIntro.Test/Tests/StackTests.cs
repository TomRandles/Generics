﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPeekAtNextItem()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Assert.AreEqual(3, stack.Peek());
        }

        [TestMethod]
        public void CanSearchWithContains()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.IsTrue(stack.Contains(2));
        }

        [TestMethod]
        public void CanConvertToArray()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var asArray = stack.ToArray();
            stack.Pop();

            Assert.AreEqual(3, asArray[0]);
            Assert.AreEqual(2, stack.Count);
        }   
    }
}