using Xunit;

namespace Roman_to_Integer.Tests;

public class RomanToIntegerTests {
    private readonly RomanToInteger _sut = new RomanToInteger();


    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void SingleSymbols_ShouldReturnCorrectValue(string s, int expected) {
        Assert.Equal(expected, _sut.RomanToInt(s));
    }
    
    [Theory]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    public void SubtractiveNotation_ShouldReturnCorrectValue(string s, int expected) {
        Assert.Equal(expected, _sut.RomanToInt(s));
    }


    [Theory]
    [InlineData("III", 3)]
    [InlineData("VIII", 8)]
    [InlineData("XIV", 14)]
    [InlineData("XLII", 42)]
    [InlineData("XCIX", 99)]
    [InlineData("CDXLIV", 444)]
    public void RegularNumbers_ShouldReturnCorrectValue(string s, int expected) {
        Assert.Equal(expected, _sut.RomanToInt(s));
    }
    
    [Theory]
    [InlineData("I", 1)]        // минимум
    [InlineData("MMMCMXCIX", 3999)] // максимум
    [InlineData("MCMXCIX", 1999)]
    [InlineData("MMXXIV", 2024)]
    public void EdgeCases_ShouldReturnCorrectValue(string s, int expected) {
        Assert.Equal(expected, _sut.RomanToInt(s));
    }
}