using System.Text.Json.Serialization;

namespace NotifyTaskAPI.Models.ValueObjects.Request
{
    public class NotifyRequest
    {
        [JsonPropertyName("message")] public string Message { get; set; }
        [JsonPropertyName("bot")] public string Bot { get; set; }
    }
}