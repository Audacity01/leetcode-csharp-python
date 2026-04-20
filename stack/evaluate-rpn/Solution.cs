using System;
using System.Collections.Generic;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        var ops = new HashSet<string> { "+", "-", "*", "/" };

        foreach (var token in tokens)
        {
            if (ops.Contains(token))
            {
                int b = stack.Pop();
                int a = stack.Pop();
                switch (token)
                {
                    case "+": stack.Push(a + b); break;
                    case "-": stack.Push(a - b); break;
                    case "*": stack.Push(a * b); break;
                    case "/": stack.Push(a / b); break;
                }
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }
}
