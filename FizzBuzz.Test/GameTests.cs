using System.Collections.Generic;
using System.Linq;
using Xunit;
using FizzBuzz;

namespace FizzBuzz.Test
{
    public class GameTests
    {
        [Fact]
        public void PlayGame_whenCalledWithRange_1_20()
        {
            //Arrange
            var rules = new List<Rule>
            {
                new Rule(3, "Fizz"),
                new Rule(5, "Buzz")
            };

            var expectedResult =
                "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\n";
            var range = Enumerable.Range(1, 20);
            //Act

            var actualResult = Game.PlayGame(range, rules);

            //Act
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void PlayGame_whenCalledWithRange_20_1()
        {
            //Arrange
            var rules = new List<Rule>
            {
                new Rule(3, "Fizz"),
                new Rule(5, "Buzz")
            };
            var rangeReversed = Enumerable.Range(1, 20).Reverse();
            var expectedResult =
                "Buzz\n19\nFizz\n17\n16\nFizzBuzz\n14\n13\nFizz\n11\nBuzz\nFizz\n8\n7\nFizz\nBuzz\n4\nFizz\n2\n1\n";


            //Act
            var actualResult = Game.PlayGame(rangeReversed, rules);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}