namespace Webdock_Backend.Models.RequestModel.Server
{
    public class ProvisionServer
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string LocationId { get; set; }
        public string ProfileSlug { get; set; }
        public string Virtualization { get; set; }
        public string ImageSlug { get; set; }
        public int SnapshotId { get; set; }

    }
}
