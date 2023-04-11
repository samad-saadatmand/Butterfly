using Butterfly.Application.Features.MathOperation.Models;

namespace Butterfly.Application.Features.MathOperation.Services;
public class MathOperationService : IMathOperationService
{
    public MathOperationService()
    {
    }

    public MathOperationResponse Add(MathOperationRequest numbers) 
    {
        var result = numbers.Num1 + numbers.Num2;
        return new(result);
    }

    public MathOperationResponse Subtract(MathOperationRequest numbers)
    {
        var result = numbers.Num1 - numbers.Num2;
        return new(result);
    }

    public MathOperationResponse Multiply(MathOperationRequest numbers)
    {
        var result = numbers.Num1 * numbers.Num2;
        return new(result);
    }

    public MathOperationResponse Divide(MathOperationRequest numbers)
    {
        if (numbers.Num2 == 0)
            throw new DivideByZeroException();

        var result = numbers.Num1 / numbers.Num2;
        return new(result);
    }
}
