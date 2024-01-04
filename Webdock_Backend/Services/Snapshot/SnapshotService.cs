using RestSharp;
using Webdock.Factory;
using Webdock.Models.RequestModel.Snapshot;
using Webdock_Backend.Models.RequestModel.snapshot;

namespace Webdock.Services.Snapshot;

public class SnapshotService: BaseWebdockService, ISnapshotService
{
    public SnapshotService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
    { }

    public async Task CreateSnapshot(CreateSnapshotRequestModel model, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"/servers/{model.ServerSlug}/snapshots");
        req.AddJsonBody(new
        {
            name = model.SnapshotName
        });

        await Client.PostAsync(req, cancellationToken);
    }
    public async Task DeleteSnapshot(DeleteSnapshotRequestModel model, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest
        {
            Resource = $"/servers/{model.ServerSlug}/snapshots{model.SnapshotId}",
            Method = Method.Post


        };


        await Client.DeleteAsync(req, cancellationToken);
    }
}