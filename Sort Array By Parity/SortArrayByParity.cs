namespace Sort_Array_By_Parity;

public class SortArrayByParityClass
{
    public int[] SortArrayByParity(int[] nums)
    {
        var left = 0;
        var right = nums.Length -1;
        while(left < right)
        {
            if (nums[left]%2 != 0 && nums[right]%2 == 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
            }

            if (nums[left] % 2 == 0) left++;   
            if (nums[right] % 2 != 0) right--;

        }
        return nums;
    }
    // Version to save the order 
    // public int[] SortArrayByParity(int[] nums) {
    //     var result = new int[nums.Length];
    //     var evens = new Queue<int>();
    //     var odds = new Queue<int>();
    //     for(int i = 0; i < nums.Length; i++)
    //     {
    //         if (nums[i]%2 == 0)
    //         {
    //             evens.Enqueue(nums[i]);
    //         }
    //         else
    //         {
    //             odds.Enqueue(nums[i]);
    //         }
    //     }


    //     var index = 0;
    //     while(evens.Count > 0) result[index++] = evens.Dequeue();
    //     while(odds.Count > 0) result[index++] = odds.Dequeue();

    //     return result;
    // }
}