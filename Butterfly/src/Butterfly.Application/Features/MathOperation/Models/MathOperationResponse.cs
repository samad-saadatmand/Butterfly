namespace Butterfly.Application.Features.MathOperation.Models;
public record MathOperationResponse
{
    public double Output { get; init; }
    public MathOperationResponse(double output)
    {
        Output = output;
    }
}