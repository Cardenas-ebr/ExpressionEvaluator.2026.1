namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<char>();
        var numberBuffer = string.Empty;

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];

            if (char.IsDigit(item) || item == '.')
            {
                numberBuffer += item;
            }
            else if (IsOperator(item))
            {
                if (!string.IsNullOrEmpty(numberBuffer))
                {
                    postFix += numberBuffer + " ";
                    numberBuffer = string.Empty;
                }

                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFix += stack.Pop() + " ";
                    }
                    if (stack.Count > 0 && stack.Peek() == '(')
                        stack.Pop(); 
                }
                else 
                {
                    while (stack.Count > 0 && stack.Peek() != '(' &&
                           PriorityStack(stack.Peek()) >= PriorityInfix(item))
                    {
                        postFix += stack.Pop() + " ";
                    }
                    stack.Push(item);
                }
            }
        }

        if (!string.IsNullOrEmpty(numberBuffer))
        {
            postFix += numberBuffer + " ";
        }
        while (stack.Count > 0)
        {
            postFix += stack.Pop() + " ";
        }

        return postFix.Trim();
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        string[] tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]) && token[0] != '(' && token[0] != ')')
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(token[0] switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    '^' => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            else
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    throw new Exception($"Sintax error: '{token}' is not a valid number or operator.");
                }
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}