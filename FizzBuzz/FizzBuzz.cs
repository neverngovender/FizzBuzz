namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string DetermineResult(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0)
                result = "Fizz";

            if (number % 5 == 0)
                result += "Buzz";

            if (string.IsNullOrWhiteSpace(result))
                result = number.ToString();

            return result;
        }
    }
}