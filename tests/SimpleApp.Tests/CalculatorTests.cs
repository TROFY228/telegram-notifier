using Xunit;
using SimpleApp;

namespace SimpleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-2, 7, 5)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Add(a, b));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }

    [Theory]
    [InlineData(17, true)]
    [InlineData(4, false)]
    public void IsPrime_ReturnsCorrectResult(int number, bool expected)
    {
        Assert.Equal(expected, _calculator.IsPrime(number));
    }
}