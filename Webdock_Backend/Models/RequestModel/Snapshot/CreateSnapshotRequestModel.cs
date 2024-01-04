namespace Webdock.Models.RequestModel.Snapshot;

public class CreateSnapshotRequestModel
{
    public string ServerSlug { get; set; } = null!;
    public string SnapshotName { get; set; } = null!;
}