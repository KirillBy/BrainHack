namespace BalancedBrackets;

public static class BalancedBrackets
{
    public static bool IsBalanced(string str)
    {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>()
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }    
        };

        foreach (var symb in str)
        {
            if (pairs.ContainsValue(symb))
            {
                stack.Push(symb);
            }
            else if (stack.Count == 0 || stack.Pop() != pairs[symb])
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}