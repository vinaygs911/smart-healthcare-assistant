using MediatR;

namespace SmartHealthAssistant.Application.Health.Queries;

public class GetHealthStatusQueryHandler : IRequestHandler<GetHealthStatusQuery, HealthStatusDto>
{
    public Task<HealthStatusDto> Handle(GetHealthStatusQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new HealthStatusDto
        {
            Status = "Healthy",
            Timestamp = DateTime.UtcNow
        });
    }
}