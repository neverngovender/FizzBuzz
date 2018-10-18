using NUnit.Framework;
using FB = FizzBuzz.FizzBuzz;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 9)]
        [TestCase("Fizz", 27)]
        [TestCase("Fizz", 63)]
        public void Given_a_number_divisable_by_3_function_will_return_Fizz(string expected, int number)
        {
            var result = FB.DetermineResult(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 20)]
        [TestCase("Buzz", 125)]
        [TestCase("Buzz", 250)]
        public void Given_a_number_divisable_by_5_function_will_return_Buzz(string expected, int number)
        {
            var result = FB.DetermineResult(number);
            Assert.AreEqual(expected, result);
        }
    }
}
