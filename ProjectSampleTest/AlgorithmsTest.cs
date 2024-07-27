using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmsTest
    {
        // [Fact(Skip="Not Implemented")]
        [Theory]
        [InlineData(-5)]
        public void InvalidInputForGetFactorial(int n)
        {
            //act
            Action act = () => Algorithms.GetFactorial(n);
            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Value should be greater than 0", exception.Message);
        }

        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(1, Algorithms.GetFactorial(1));
            Assert.Equal(2, Algorithms.GetFactorial(2));
            Assert.Equal(6, Algorithms.GetFactorial(3));
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Fact]
        public void CanFormatSeperators()
        {
          Assert.Equal("a, b and c", Algorithms.FormatSeperators("a","b","c"));
        }

        [Fact]
        public void InvalidInputForCanFormatSeperators()
        {
            //act
            Action act = () => Algorithms.FormatSeperators(null);
            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Please provide items to format.", exception.Message);
        }
    }
}
