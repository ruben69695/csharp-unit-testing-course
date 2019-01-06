using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_PassNumberDivisibleByThreeAndFive_ShouldReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        
        [Test]
        public void GetOutput_InputDivisibleOnlyByThree_ShouldReturnFizz()
        {
            var result = FizzBuzz.GetOutput(6);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        [Test]
        public void GetOutput_InputDivisibleOnlyByFive_ShouldReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        
        [Test]
        public void GetOutput_InputNotDivisibleByThreeOrFive_ShouldReturnTheNumber()
        {
            var result = FizzBuzz.GetOutput(4);
            
            Assert.That(result, Is.EqualTo("4"));
        }
    }
}