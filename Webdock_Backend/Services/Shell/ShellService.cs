using RestSharp;
using Webdock.Factory;
using Webdock.Services;
using Webdock_Backend.Models.Shell;

namespace Webdock_Backend.Services.Shell;

    public class ShellService: BaseWebdockService, IShellService
    {
        public ShellService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
        { }

        public async Task CreateShellUserAsync(ShellUser model, CancellationToken cancellationToken = default)
        {
        var req = new RestRequest($"/servers/{model.ServerSlug}/shellUsers");
        req.AddJsonBody(new
        {
            name = model.UserName,
            password = model.PassWord,
            group=model.Group,
            shell=model.Shell,
            publickey =model.PublicKey

        });

        await Client.PostAsync(req, cancellationToken);
    }
    }

