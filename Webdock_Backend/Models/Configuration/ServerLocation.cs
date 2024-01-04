namespace Webdock_Backend.Models.Configuration
{
    public class ServerLocation
    {
        public string Id { get; init; }
        public string Name { get; init; } = null!;
        public string City { get; init; } = null!;
        public string Country { get; init; } = null!;
        public string description { get; init; } = null!;
        public string Icon { get; init; } = null!;

    }
}
