using Newtonsoft.Json;
using System.Collections.Generic;

namespace RedisTrialApp.Models
{
    public class MovieList
    {
        [JsonProperty("cast")]
        public List<Movie> Movies { get; set; }
    }
}
