using Xunit;

public class PalindromeCheckerTests
{
    [Fact]
    public void IsPalindrome_ShouldReturnTrueForPalindromeNumber()
    {
        // Arrange
        var checker = new PalindromeChecker();

        // Act & Assert
        Assert.True(checker.IsPalindrome(121));
        Assert.True(checker.IsPalindrome(12321));
    }

    [Fact]
    public void IsPalindrome_ShouldReturnFalseForNonPalindromeNumber()
    {
        // Arrange
        var checker = new PalindromeChecker();

        // Act & Assert
        Assert.False(checker.IsPalindrome(123));
        Assert.False(checker.IsPalindrome(123456));
    }
}
