namespace Butterfly.Application.Features.MathOperation.Models;
public record MathOperationRequest
{
    public double Num1 { get; init; }
    public double Num2 { get; init; }

    public MathOperationRequest(double num1, double num2)
    {
        (Num1, Num2) = (num1, num2);
    }
}