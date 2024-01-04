using Webdock.Models.Response;

namespace Webdock.Services;

public interface IPingService
{
    public Task<PingResponse> GetPing(CancellationToken cancellationToken = default);
    public Task<PingResponse> GetPingAsync(CancellationToken cancellationToken = default);
}