using Butterfly.Application.Features.MathOperation.Models;

namespace Butterfly.Application.Features.MathOperation.Services;
public interface IMathOperationService
{
    MathOperationResponse Add(MathOperationRequest numbers);
    MathOperationResponse Divide(MathOperationRequest numbers);
    MathOperationResponse Multiply(MathOperationRequest numbers);
    MathOperationResponse Subtract(MathOperationRequest numbers);
}