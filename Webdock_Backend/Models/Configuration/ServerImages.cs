namespace Webdock_Backend.Models.Configuration
{
    public class ServerImages
    {
        public string Slug { get; init; }
        public string Name { get; init; } = null!;
        public string Webserver { get; init; } = null!;
        public string PhpVersion { get; init; } = null!;

    }
}
