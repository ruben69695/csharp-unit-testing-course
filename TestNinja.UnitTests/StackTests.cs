using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;
        
        [SetUp]
        public void Setup()
        {
            _stack = new Stack<string>();
        }
        
        [Test]
        public void Push_PushNullItem_ShouldThrowArgumentNullException()
        {
            Assert.That(() => { _stack.Push(null); }, 
                Throws.ArgumentNullException);
        }

        [Test]
        public void Push_PushItems_ShouldPushTheItems()
        {
            _stack.Push("item1");
            _stack.Push("item2");
            _stack.Push("item3");
            
            Assert.That(_stack.Count, Is.EqualTo(3));
        }

        [Test]
        public void Pop_PopAnItemWhenStackIsEmpty_ShouldThrowAnInvalidOperationException()
        {
            Assert.That(() => { var result = _stack.Pop(); },
                Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_PopAnItem_ShouldPopTheItemOnTheStack()
        {
            _stack.Push("item1");
            _stack.Push("item2");

            var result = _stack.Pop();
            
            Assert.That(result, Is.EqualTo("item2"));
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_PeekEmptyStack_ShouldThrowInvalidOperationException()
        {
            Assert.That(() => { var result = _stack.Peek(); }, 
                Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_PeekLastItem_ReturnTheLastItemOnTheStackButDontRemoveIt()
        {   
            _stack.Push("item1");
            _stack.Push("item2");

            var result = _stack.Peek();
            
            Assert.That(result, Is.EqualTo("item2"));
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
    }
}