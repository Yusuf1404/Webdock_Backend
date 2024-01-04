using RestSharp;
using System.Dynamic;
using System.Reflection;
using Webdock.Factory;
using Webdock.Models.Response.Account;
using Webdock_Backend.Models.RequestModel.Server;

namespace Webdock.Services.Account;

public class ServerService: BaseWebdockService, IServerService
{

    public ServerService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
    { }

    public async Task CreateServer(ProvisionServer model, CancellationToken cancellationToken = default)
    {

        var req = new RestRequest("/servers");
        req.AddJsonBody(new
        {
            name = model.Name,
            slug=model.Slug,
            locationid =model.LocationId,
            profileslug =model.ProfileSlug,
            virtualization = model.Virtualization,
            imageslug = model.ImageSlug,
            snapshotid = model.SnapshotId,
        });
         
    await Client.PostAsync(req, cancellationToken);

    }
}