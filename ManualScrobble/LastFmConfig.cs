using System.Configuration;

namespace ManualScrobble
{
    public class LastFmConfig
    {
        public string ApiKey { get; }
        public string ApiSecret { get; }
        public string Username { get; }
        public string Password { get; }

        public LastFmConfig()
        {
            ApiKey = ConfigurationManager.AppSettings["LastFmApiKey"];
            ApiSecret = ConfigurationManager.AppSettings["LastFmApiSecret"];
            Username = ConfigurationManager.AppSettings["LastFmUserName"];
            Password = ConfigurationManager.AppSettings["LastFmUserPassword"];
        }
    }
}