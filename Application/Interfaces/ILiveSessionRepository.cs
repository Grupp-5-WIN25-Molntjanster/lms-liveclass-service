using System.Threading.Tasks;
using Lms.LiveClassService.Domain.Entities;

namespace Lms.LiveClassService.Application.Interfaces;

public interface ILiveSessionRepository
{
    Task<LiveSession> GetActiveSessionAsync();
}