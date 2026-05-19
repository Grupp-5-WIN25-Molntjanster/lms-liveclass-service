namespace Lms.LiveClassService.Application.DTOs;

public class LiveSessionDetailDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;
    public string VideoUrl { get; set; } = string.Empty;
    public List<ViewerDto> Viewers { get; set; } = new();
}