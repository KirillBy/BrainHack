using Binary_Search;

namespace UnitTests;

public class BinarySearchTests
{
    private readonly BinarySearch _solution = new BinarySearch();

    [Fact]
    public void TargetFound_Middle()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        Assert.Equal(4, _solution.Search(nums, 9));
    }

    [Fact]
    public void TargetNotFound()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        Assert.Equal(-1, _solution.Search(nums, 2));
    }

    [Fact]
    public void TargetIsFirstElement()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        Assert.Equal(0, _solution.Search(nums, -1));
    }

    [Fact]
    public void TargetIsLastElement()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        Assert.Equal(5, _solution.Search(nums, 12));
    }

    [Fact]
    public void SingleElement_Found()
    {
        int[] nums = { 5 };
        Assert.Equal(0, _solution.Search(nums, 5));
    }

    [Fact]
    public void SingleElement_NotFound()
    {
        int[] nums = { 5 };
        Assert.Equal(-1, _solution.Search(nums, -5));
    }

    [Fact]
    public void TwoElements_FoundFirst()
    {
        int[] nums = { 2, 5 };
        Assert.Equal(0, _solution.Search(nums, 2));
    }

    [Fact]
    public void TwoElements_FoundSecond()
    {
        int[] nums = { 2, 5 };
        Assert.Equal(1, _solution.Search(nums, 5));
    }

    [Fact]
    public void TargetSmallerThanAll()
    {
        int[] nums = { 1, 3, 5, 7, 9 };
        Assert.Equal(-1, _solution.Search(nums, 0));
    }

    [Fact]
    public void TargetLargerThanAll()
    {
        int[] nums = { 1, 3, 5, 7, 9 };
        Assert.Equal(-1, _solution.Search(nums, 100));
    }

    [Fact]
    public void NegativeNumbers()
    {
        int[] nums = { -100, -50, -20, -1 };
        Assert.Equal(1, _solution.Search(nums, -50));
    }

    [Fact]
    public void LargeArray_Found()
    {
        int[] nums = new int[10000];
        for (int i = 0; i < 10000; i++)
            nums[i] = -10000 + i * 2;

        int target = 4568;
        int expectedIndex = Array.IndexOf(nums, target);

        Assert.Equal(expectedIndex, _solution.Search(nums, target));
    }

    [Fact]
    public void LargeArray_NotFound()
    {
        int[] nums = new int[10000];
        for (int i = 0; i < 10000; i++)
            nums[i] = -10000 + i * 2;

        Assert.Equal(-1, _solution.Search(nums, 4567));
    }
}