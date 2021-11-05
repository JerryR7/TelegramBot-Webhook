namespace NotifyTaskAPI.Models.ValueObjects.Request
{
    public class BotMessageRequest
    {
        public string chat_id { get; set; }
        public string text { get; set; }
    }
}