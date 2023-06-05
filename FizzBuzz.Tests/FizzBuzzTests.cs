using System;
using Xunit;
using FluentAssertions;

//? Given an integer, return a string where:
// "Fizzbuzz" if number is divisible by 3 and 5.
// "Fizz" if number is divisible by 3.
// "Buzz" if number is divisible by 5.
// echo number (as a string) if none of the above conditions are true.

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Play_WhenCalled_ReturnsAString()
        {
            //Act
            var result = FizzBuzzGame.Play(1);
            //Assert
            Assert.IsType<string>(result);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void GivenANumberNotDivisbleBy3Or5_ThenReturnsNumberAsString(int num)
        {
            //Act
            string result = FizzBuzzGame.Play(num);
            //Assert
            result.Should().Be(num.ToString());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenANumberDivisibleBy5_ThenReturnsBuzz(int num)
        {
            //Act
            var result = FizzBuzzGame.Play(num);
            //Assert
            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void GivenANumberDivisibleBy3_ThenReturnsFizz(int num)
        {
            //Act
            var result = FizzBuzzGame.Play(num);
            //Assert
            result.Should().Be("Fizz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void GivenANumberDivisibleBy3And5_ThenReturnsFizzBuzz(int num)
        {
            //Act
            var result = FizzBuzzGame.Play(num);
            //Assert
            result.Should().Be("FizzBuzz");
        }

    }
}
