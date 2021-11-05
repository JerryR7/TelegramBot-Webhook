using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotifyTaskAPI.Models;
using NotifyTaskAPI.Models.ValueObjects.Request;

namespace NotifyTaskAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Produces("application/json")]
    public class NotifyTaskController : ControllerBase
    {
        private readonly ILogger<NotifyTaskController> _logger;

        public NotifyTaskController(ILogger<NotifyTaskController> logger)
        {
            _logger = logger;
        }
        
        public string SendMessage([FromBody] NotifyRequest postMessage)
        {
            var bot = new TelegramBot();
            return bot.Chat(postMessage.Message);
        }
    }
}