using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class FibonacciCalculatorTests
{
    [TestMethod]
    public void GetFibonacciNumbers_ShouldReturnCorrectSequenceForN5()
    {
        // Arrange
        var calculator = new FibonacciCalculator();
        var expected = new List<int> { 0, 1, 1, 2, 3 };

        // Act
        var result = calculator.GetFibonacciNumbers(5);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GetFibonacciNumbers_ShouldThrowArgumentExceptionForNegativeInput()
    {
        // Arrange
        var calculator = new FibonacciCalculator();

        // Act & Assert
        calculator.GetFibonacciNumbers(-1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GetFibonacciNumbers_ShouldThrowArgumentExceptionForZeroInput()
    {
        // Arrange
        var calculator = new FibonacciCalculator();

        // Act & Assert
        calculator.GetFibonacciNumbers(0);
    }
}
