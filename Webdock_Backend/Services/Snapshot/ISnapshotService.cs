using Webdock.Models.RequestModel.Snapshot;

namespace Webdock.Services.Snapshot;

public interface ISnapshotService
{
    public Task CreateSnapshot(CreateSnapshotRequestModel model, CancellationToken cancellationToken = default);
}