namespace Palindrome_Number;

public class PalindromeNumber
{
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}