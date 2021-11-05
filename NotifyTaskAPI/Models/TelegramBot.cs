using Microsoft.Extensions.Configuration;
using NotifyTaskAPI.Models.ValueObjects.Request;

namespace NotifyTaskAPI.Models
{
    public class TelegramBot : BotFather
    {
        private string ChatId { get; }
        private string BotToken { get; }
        private string ApiUrl { get; }

        public TelegramBot()
        {
            var telegramConfig = BotConfig.GetSection("TELEGRAM");

            ChatId = telegramConfig.GetValue<string>("ChatId");
            BotToken = telegramConfig.GetValue<string>("BotToken");
            ApiUrl = $"https://api.telegram.org/{BotToken}/sendMessage";
        }

        public override string Chat(string message)
        {
            var botMessageRequest = new BotMessageRequest
            {
                chat_id = ChatId,
                text = message
            };

            return UrlTool.Send(ApiUrl, botMessageRequest).ToString();
        }
    }
}