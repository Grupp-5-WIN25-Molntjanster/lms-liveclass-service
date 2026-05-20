using Lms.LiveClassService.Application.Interfaces;
using Lms.LiveClassService.Domain.Entities;

namespace Lms.LiveClassService.Infrastructure.Repositories;

public class LiveSessionMockRepository : ILiveSessionRepository
{
    public Task<LiveSession> GetActiveSessionAsync()
    {
        var session = new LiveSession
        {
            Id = Guid.NewGuid(),
            Title = "Foundations of Digital Marketing",
            HostName = "John Does",
            VideoUrl = "",
            Viewers = new List<Viewer>
            {
                new Viewer { Id = Guid.NewGuid(), Name = "Student 1", AvatarUrl = "" },
                new Viewer { Id = Guid.NewGuid(), Name = "Student 2", AvatarUrl = "" },
                new Viewer { Id = Guid.NewGuid(), Name = "Student 3", AvatarUrl = "" },
                new Viewer { Id = Guid.NewGuid(), Name = "Student 4", AvatarUrl = "" }
            }
        };

        return Task.FromResult(session);
    }
}