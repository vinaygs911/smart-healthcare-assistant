using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartHealthAssistant.Application.Health.Queries;

namespace SmartHealthAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly IMediator _mediator;

    public HealthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetHealthStatusQuery());
        return Ok(result);
    }
}