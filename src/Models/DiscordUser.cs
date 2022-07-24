namespace RazerRPC.Models
{
    public class DiscordUser
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public string discriminator { get; set; }
        public int public_flags { get; set; }
        public string ConvertedFlags { get; set; }

        public string GetAvatar()
        {
            return $"https://cdn.discordapp.com/avatars/{id}/{avatar}";
        }
    }
}