namespace SelectionSort;

public class SelectionSort
{
    public int[] Sort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int minIndex = i;
            for(int j = i; j < nums.Length; j++)
            {
                if (nums[j] < nums[minIndex]) minIndex = j;
            }
            (nums[i], nums[minIndex]) = (nums[minIndex], nums[i]);
        }
        return nums;
    }
}