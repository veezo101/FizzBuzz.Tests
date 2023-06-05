//? Given an integer, return a string where:
// "Fizzbuzz" if number is divisible by 3 and 5.
// "Fizz" if number is divisible by 3.
// "Buzz" if number is divisible by 5.
// echo number (as a string) if none of the above conditions are true.

using System.Linq;
using System.Xml.Serialization;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGame
    {
        public static string Play(int number)
        {
            string res = "";
            switch (number)
            {
                case var n when n % 3 == 0 && n % 5 == 0:
                    res = res + "FizzBuzz";
                    break;
                case var n when n%3 == 0:
                    res = res + "Fizz";
                    break;
                case var n when n % 5 == 0:
                    res = res + "Buzz";
                    break;
                default:
                    res = res + number.ToString();
                    break;
            }
            return res;
        }
    }
}
