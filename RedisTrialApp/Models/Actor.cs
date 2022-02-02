using Newtonsoft.Json;

namespace RedisTrialApp.Models
{
    public class Actor
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
