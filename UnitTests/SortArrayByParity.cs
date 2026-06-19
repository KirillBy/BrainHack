using Sort_Array_By_Parity;

namespace UnitTests;

using Xunit;


public class SortArrayByParityTests {
    private readonly SortArrayByParityClass _sut = new SortArrayByParityClass();

    // Основные кейсы
    [Fact]
    public void BasicCase_ShouldPlaceEvensFirst() {
        var result = _sut.SortArrayByParity(new[] { 3, 1, 2, 4 });
        Assert.True(IsValidAnswer(result));
    }

    [Fact]
    public void SingleElement_Even_ShouldReturnSame() {
        var result = _sut.SortArrayByParity(new[] { 0 });
        Assert.Equal(new[] { 0 }, result);
    }

    [Fact]
    public void SingleElement_Odd_ShouldReturnSame() {
        var result = _sut.SortArrayByParity(new[] { 1 });
        Assert.Equal(new[] { 1 }, result);
    }

    // Граничные случаи
    [Fact]
    public void AllEvens_ShouldReturnSameOrder() {
        var result = _sut.SortArrayByParity(new[] { 2, 4, 6, 8 });
        Assert.True(IsValidAnswer(result));
    }

    [Fact]
    public void AllOdds_ShouldReturnSameOrder() {
        var result = _sut.SortArrayByParity(new[] { 1, 3, 5, 7 });
        Assert.True(IsValidAnswer(result));
    }

    [Fact]
    public void AlreadySorted_ShouldRemainValid() {
        var result = _sut.SortArrayByParity(new[] { 2, 4, 1, 3 });
        Assert.True(IsValidAnswer(result));
    }

    [Fact]
    public void WithZero_ShouldTreatAsEven() {
        var result = _sut.SortArrayByParity(new[] { 0, 1, 2 });
        Assert.True(IsValidAnswer(result));
        Assert.Equal(0, result[0] % 2); // первый элемент чётный
    }

    // Хелпер — проверяет что все чётные идут перед нечётными
    private bool IsValidAnswer(int[] nums) {
        bool oddFound = false;
        foreach (var n in nums) {
            if (n % 2 != 0) oddFound = true;
            if (oddFound && n % 2 == 0) return false;
        }
        return true;
    }
}