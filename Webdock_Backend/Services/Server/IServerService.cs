using Webdock.Models.Response.Account;
using Webdock_Backend.Models.RequestModel.Server;

namespace Webdock.Services.Account;

public interface IServerService
{
    public Task CreateServer(ProvisionServer model, CancellationToken cancellationToken = default);
}