using Palindrome_Number;

namespace UnitTests;

public class PalindromeTest
{
    private readonly PalindromeNumber _sut =  new PalindromeNumber();
    [Theory]
    [InlineData(121)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(11)]
    [InlineData(1221)]
    [InlineData(12321)]
    public void IsPalindrome_ShouldReturnTrue(int x) {
        Assert.True(_sut.IsPalindrome(x));
    }
    
    [Theory]
    [InlineData(-121)]  // отрицательное
    [InlineData(10)]    // оканчивается на 0
    [InlineData(123)]   // не палиндром
    [InlineData(-1)]    // отрицательное
    public void IsPalindrome_ShouldReturnFalse(int x) {
        Assert.False(_sut.IsPalindrome(x));
    }
}