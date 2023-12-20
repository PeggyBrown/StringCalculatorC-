using FluentAssertions;
using Xunit;

namespace StringCalculatorKata
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Fact]
        public void ShouldAddValuesWithFluentAssertions()
        {
            var result = 2 + 2;
            result.Should().Be(4);
        }
        
                
        [Fact]
        public void ShouldReturnTheValueOfNumber()
        {
            StringCalculator calculator = new StringCalculator();
            var result = calculator.Add("0");
            result.Should().Be(0);
        }
        
        [Fact]
        public void ShouldReturnTheSumOfTwoNumber()
        {
            StringCalculator calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            result.Should().Be(3);
        }
    }
}