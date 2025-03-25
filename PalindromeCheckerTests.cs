[TestClass]
public class PalindromeCheckerTests
{
    [TestMethod]
    public void IsPalindrome_ShouldReturnTrueForPalindromeNumber()
    {
        // Arrange
        var checker = new PalindromeChecker();

        // Act & Assert
        Assert.IsTrue(checker.IsPalindrome(121));
        Assert.IsTrue(checker.IsPalindrome(12321));
    }

    [TestMethod]
    public void IsPalindrome_ShouldReturnFalseForNonPalindromeNumber()
    {
        // Arrange
        var checker = new PalindromeChecker();

        // Act & Assert
        Assert.IsFalse(checker.IsPalindrome(123));
        Assert.IsFalse(checker.IsPalindrome(123456));
    }
}
