using Xunit;

public class FibonacciCalculatorTests
{
    [Fact]
    public void GetFibonacciNumbers_ShouldReturnCorrectSequenceForN5()
    {
        // Arrange
        var calculator = new FibonacciCalculator();
        var expected = new List<int> { 0, 1, 1, 2, 3 };

        // Act
        var result = calculator.GetFibonacciNumbers(5);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetFibonacciNumbers_ShouldThrowArgumentExceptionForNegativeInput()
    {
        // Arrange
        var calculator = new FibonacciCalculator();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.GetFibonacciNumbers(-1));
    }

    [Fact]
    public void GetFibonacciNumbers_ShouldThrowArgumentExceptionForZeroInput()
    {
        // Arrange
        var calculator = new FibonacciCalculator();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.GetFibonacciNumbers(0));
    }
}
