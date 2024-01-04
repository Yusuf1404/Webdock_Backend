using Webdock.Models.Response;
using Webdock_Backend.Models.Shell;

namespace Webdock_Backend.Services.Shell
{
    public interface IShellService
    {
        public Task CreateShellUserAsync(ShellUser model, CancellationToken cancellationToken = default);
    }
}
