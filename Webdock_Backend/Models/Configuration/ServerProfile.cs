namespace Webdock_Backend.Models.Configuration
{
    public class ServerProfile

    {
        public string Slug { get; init; }
        public string Name { get; init; } = null!;
        public string Ram { get; init; } = null!;
        public string Disk { get; init; } = null!;
        public string Cpu { get; init; } = null!;
        public string price { get; init; } = null!;

        public string LocationId { get; init; } = null!;

        public class CPU
        {
            public int Cores { get; init; } =0!;
            public int Threads { get; init; } =0!;

        }

        public class Price
        {
            public double Amount { get; init; } =0!;

            public string Currency { get; init; } = null!;
        }

    }
}
