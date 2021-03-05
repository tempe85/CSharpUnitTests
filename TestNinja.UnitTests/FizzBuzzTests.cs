using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //MethodTesting_ScenarioTesting_ExpectedBehavior
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_DivisibleByThreeButNotFive_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(6);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisibleByFiveButNotThree_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_DivisibleByFiveAndThree_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NotDivisibleByFiveOrThree_ReturnsInputNumberAsString()
        {
            var result = FizzBuzz.GetOutput(7);
            Assert.That(result, Is.EqualTo("7"));
        }
    }
}
