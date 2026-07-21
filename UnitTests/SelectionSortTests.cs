namespace UnitTests;

using Xunit;

public class SelectionSortTests
{
    private readonly SelectionSort.SelectionSort _solution = new SelectionSort.SelectionSort();

    [Fact]
    public void EmptyArray()
    {
        int[] nums = { };
        int[] expected = { };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleElement()
    {
        int[] nums = { 5 };
        int[] expected = { 5 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void AlreadySorted()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseSorted()
    {
        int[] nums = { 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void RandomOrder()
    {
        int[] nums = { 3, 1, 4, 1, 5, 9, 2, 6 };
        int[] expected = { 1, 1, 2, 3, 4, 5, 6, 9 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateElements()
    {
        int[] nums = { 4, 2, 4, 2, 4, 2 };
        int[] expected = { 2, 2, 2, 4, 4, 4 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void AllSameElements()
    {
        int[] nums = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void NegativeNumbers()
    {
        int[] nums = { -5, 3, -1, 0, -10, 8 };
        int[] expected = { -10, -5, -1, 0, 3, 8 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoElements_Unsorted()
    {
        int[] nums = { 2, 1 };
        int[] expected = { 1, 2 };

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LargeRandomArray()
    {
        var random = new Random(42);
        int[] nums = new int[1000];
        for (int i = 0; i < nums.Length; i++)
            nums[i] = random.Next(-1000, 1000);

        int[] expected = (int[])nums.Clone();
        Array.Sort(expected);

        int[] result = _solution.Sort(nums);

        Assert.Equal(expected, result);
    }
}