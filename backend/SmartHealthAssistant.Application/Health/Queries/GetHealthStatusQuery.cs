using MediatR;

namespace SmartHealthAssistant.Application.Health.Queries;

public class GetHealthStatusQuery : IRequest<HealthStatusDto>
{
}