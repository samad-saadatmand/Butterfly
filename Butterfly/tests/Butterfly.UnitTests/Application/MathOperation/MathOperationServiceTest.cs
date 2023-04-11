using Butterfly.Application.Features.MathOperation.Models;
using Butterfly.Application.Features.MathOperation.Services;
using Xunit;

namespace Butterfly.UnitTests.Application.MathOperation;
public class MathOperationServiceTest
{
    public MathOperationServiceTest()
    {

    }

    [Theory]
    [InlineData(2, 3)]
    [InlineData(4, 5)]
    [InlineData(1, 3)]
    public void Add_WhenTwoNumbersArePositive_ReturnsPositiveNumber(int num1, int num2)
    {
        //Arrange
        MathOperationService service = new();
        MathOperationRequest model = new(num1, num2);

        //Act
        var result = service.Add(model);

        //Assert
        Assert.True(result.Output > 0);
    }

    [Theory]
    [InlineData(2, 2)]
    [InlineData(50, 50)]
    [InlineData(8, 8)]
    public void Subtract_WhenTwoPositiveNumbersAreEqual_ReturnsZero(int num1, int num2)
    {
        //Arrange
        MathOperationService service = new();
        MathOperationRequest model = new(num1, num2);

        //Act
        var result = service.Subtract(model);

        //Assert
        Assert.Equal(0, result.Output);
    }

    [Fact]
    public void Divide_WhenSecondNumberIsZero_ReturnsException()
    {
        //Arrange
        MathOperationService service = new();
        MathOperationRequest model = new(8, 0);

        //Act
        var result = () => service.Divide(model);

        //Assert
        Assert.Throws<DivideByZeroException>(result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(2, -3, -6)]
    [InlineData(0, 3, 0)]
    [InlineData(int.MaxValue, 1, int.MaxValue)]
    public void Multiply_WhenGiveCorrectValues_ReturnsExpectedValue(int num1, int num2, double expected)
    {
        //Arrange
        MathOperationService service = new();
        MathOperationRequest model = new(num1, num2);

        //Act
        var result = service.Multiply(model);

        //Assert
        Assert.Equal(expected, result.Output);
    }
}