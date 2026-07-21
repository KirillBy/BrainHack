namespace Binary_Search;

public class BinarySearch
{
    public int Search(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) low = mid + 1;
            if (arr[mid] > target) high = mid - 1;
        }
        return -1;
    }
}