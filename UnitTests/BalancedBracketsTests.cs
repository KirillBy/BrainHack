namespace UnitTests;

public class BalancedBracketsTests
{
    [Theory]
    [InlineData("{([]{})}")]
    [InlineData("[]{([]{})}")]
    [InlineData("")]
    public void IsBalanced_WithCorrectString_ReturnTrue(string inlineData)
    {
        //Arrange
        var correctString = inlineData;
        
        //Act
        var result = BalancedBrackets.BalancedBrackets.IsBalanced(correctString);
        
        //Assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("[{}")]
    public void IsBalanced_WithIncorrectString_ReturnFalse(string inlineData)
    {
        //Arrange
        var incorrectString = inlineData;
        
        //Act
        var result = BalancedBrackets.BalancedBrackets.IsBalanced(incorrectString);
        
        //Assert
        Assert.False(result);
    }
}