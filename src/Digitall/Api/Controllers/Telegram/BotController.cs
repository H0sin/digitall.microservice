using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Filters;
using Telegram.Bot.Services;
using Telegram.Bot.Types;

namespace Telegram.Bot.Controllers;

public class BotController : ControllerBase
{
 private readonly ILogger<BotController> _logger;

 public BotController(ILogger<BotController> logger)
 {
     _logger = logger;
     _logger.LogInformation("bot started");
 }

 [HttpPost]
//  [ValidateTelegramBot]
 public async Task<IActionResult> Post(
     [FromBody] Update update,
     [FromServices] UpdateHandlers handleUpdateService,
     CancellationToken cancellationToken)
 {
     if (update == null)
        {
            // Handle null update scenario
            return BadRequest("Update object is null");
        }
        
     await handleUpdateService.HandleUpdateAsync(update, cancellationToken);
     return Ok();
 }
}
