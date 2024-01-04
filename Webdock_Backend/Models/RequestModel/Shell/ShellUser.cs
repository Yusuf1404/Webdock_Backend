namespace Webdock_Backend.Models.Shell
{
    public class ShellUser
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Group { get; set; }
        public string Shell { get; set; }
        public int PublicKey { get; set; }
        public string ServerSlug { get; set; }
    }

}

