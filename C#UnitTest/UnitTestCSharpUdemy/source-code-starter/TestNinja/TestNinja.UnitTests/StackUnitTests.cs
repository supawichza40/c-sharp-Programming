
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackUnitTests
    {
        private Stack<string> stackObj;
        [SetUp]
        public void SetUp()
        {
            stackObj = new Stack<string>();
        }
        [Test]
        public void Push_WhereObjectIsNull_ReturnArgumentNullException()
        {
            stackObj = new Stack<string>();
            //Stack<int> stackObj = new Stack<int>();
            //int? nullInt = null;

            Assert.That(() => stackObj.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_WhereObjectIsValid_AddObjectToStackAndCount()
        {
            stackObj = new Stack<string>();
            stackObj.Push("Hello");
            Assert.That(stackObj.Count, Is.EqualTo(1));
        }
        [Test]
        public void Pop_WhereObjectCountIsZero_ReturnInvalidOperationException()
        {
            stackObj = new Stack<string>();
            Assert.That(() => stackObj.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_ObjectIsPresent_ReturnValueOneLess()
        {
            stackObj = new Stack<string>();
            stackObj.Push("A");
            stackObj.Push("B");
            stackObj.Pop();
            Assert.That(stackObj.Count, Is.EqualTo(1));
        }
        [Test]
        public void Peek_ObjectIsNull_ReturnInvalidOperationException()
        {
            stackObj = new Stack<string>();
            Assert.That(() => stackObj.Peek(), Throws.InvalidOperationException);
                
        }
        [Test]
        public void Peek_ObjectPresent_ReturnTopStackObject()
        {
            stackObj = new Stack<string>();
            stackObj.Push("1");
            stackObj.Push("2");
            Assert.AreEqual(stackObj.Peek(), "2");
        }
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            stackObj = new Stack<string>();
            Assert.That(stackObj.Count, Is.EqualTo(0));
        }
        [Test]
        public void Count_NotEmptyStack_ReturnNumberOfObject()
        {
            stackObj = new Stack<string>();
            stackObj.Push("a");
            Assert.That(stackObj.Count, Is.EqualTo(1));

        }
    }
}
