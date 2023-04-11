using Butterfly.Application.Features.MathOperation.Models;
using Butterfly.Application.Features.MathOperation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Butterfly.API.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class MathOperationController : ControllerBase
{
    private readonly IMathOperationService _mathOperationService;
    public MathOperationController(IMathOperationService mathOperationService)
    {
        _mathOperationService = mathOperationService;
    }

    [HttpPost("add")]
    [ProducesResponseType(typeof(MathOperationResponse), (int)HttpStatusCode.OK)]
    public ActionResult<MathOperationResponse> Add([FromBody] MathOperationRequest request)
    {
        return Ok(_mathOperationService.Add(request));
    }

    [HttpPost("subtract")]
    [ProducesResponseType(typeof(MathOperationResponse), (int)HttpStatusCode.OK)]
    public ActionResult<MathOperationResponse> Subtract([FromBody] MathOperationRequest request)
    {
        return Ok(_mathOperationService.Subtract(request));
    }

    [HttpPost("multiply")]
    [ProducesResponseType(typeof(MathOperationResponse), (int)HttpStatusCode.OK)]
    public ActionResult<MathOperationResponse> Multiply([FromBody] MathOperationRequest request)
    {
        return Ok(_mathOperationService.Multiply(request));
    }

    [HttpPost("divide")]
    [ProducesResponseType(typeof(MathOperationResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    public ActionResult<MathOperationResponse> Divide([FromBody] MathOperationRequest request)
    {
        try
        {
            return Ok(_mathOperationService.Divide(request));
        }
        catch (DivideByZeroException)
        {
            return BadRequest("Division by zero is not allowed.");
        }
    }
}