using Newtonsoft.Json;

namespace RedisTrialApp.Models
{
    public class Movie
    {
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
