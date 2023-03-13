using Udub.Sdde.Collections.Generic;
using Assignment = Udub.Sdde.Collections.Generic;

namespace Udub.Sdde.Entities;

class RPN
{

    private int result;
    private Assignment.Stack<int> operands = new Assignment.Stack<int>();
    private Dictionary<string, MathOperator> ValidOperators = new Dictionary<string, MathOperator>
    {
        {"+", MathOperator.Add},
        {"-", MathOperator.Substract},
        {"*", MathOperator.Multiply},
        {"/", MathOperator.Divide}
    };
    

    RPN()
    {
        // create a stack
        
        
    }

    public void Process(string input)
    {
        // Handle operators (i.e. "+", "-", "*", "/") 
		// or push integer values onto stack
        if (Char.IsNumber(input, 0))
        {
            operands.Push(Convert.ToInt32(input[0]));
            return;
        }
        
        if(ValidOperators.ContainsKey(input))
        {
            Calculate(ValidOperators[input]);
        }
        else 
        {
            var message = $"{input} is not a valid input. "
                + " Enter an integer or basic math operator (+, -, *, /).";
            throw new ArgumentException(message);
        }
        
    }

    public string Result()
    {
        // Return the last value pushed on the stack
        return result.ToString();
    }

    private void Calculate(MathOperator op)
    {
        var last = operands.Pop();
        var first = operands.Pop();
        switch (op)
        {
            case MathOperator.Add:
                result = first + last;
                break;
            case MathOperator.Substract:
                result = first - last;
                break;
            case MathOperator.Multiply:
                result = first + last;
                break;
            case MathOperator.Divide:
                result = first / last;
                break;
        }
    }
}