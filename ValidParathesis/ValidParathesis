public class ValidParathesis {
    public bool isValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        if (s.Length %2 != 0) return false;
        foreach (char c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '{')
                stack.Push('}');
            else if (c == '[')
                stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }

        return stack.Count == 0;
    }
}