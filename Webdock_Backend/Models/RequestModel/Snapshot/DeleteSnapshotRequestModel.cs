namespace Webdock_Backend.Models.RequestModel.snapshot
{
    public class DeleteSnapshotRequestModel
    {
        public string ServerSlug { get; set; } = null!;

        public int SnapshotId { get; set; }
    }
}
