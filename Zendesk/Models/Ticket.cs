using Newtonsoft.Json;

namespace Zendesk.Models
{
    public class Ticket
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("subject")]
        public string? Subject { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("priority")]
        public string? Priority { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("created_at")]
        public string? Created_At { get; set; }
    }
}
