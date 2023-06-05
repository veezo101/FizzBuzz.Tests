//? Given an integer, return a string where:
// "Fizzbuzz" if number is divisible by 3 and 5.
// "Fizz" if number is divisible by 3.
// "Buzz" if number is divisible by 5.
// echo number (as a string) if none of the above conditions are true.

namespace FizzBuzz.Tests
{
    public class FizzBuzzGame
    {
        public static string Play(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
