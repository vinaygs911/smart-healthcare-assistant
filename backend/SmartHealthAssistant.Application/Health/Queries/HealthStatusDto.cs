namespace SmartHealthAssistant.Application.Health.Queries;

public class HealthStatusDto
{
    public string Status { get; set; } = "Healthy";
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}