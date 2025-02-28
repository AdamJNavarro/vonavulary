using CogLog.UI.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CogLog.UI.Controllers;

public class TopicsController(ITopicService topicService) : Controller
{
    // INDEX
    public async Task<IActionResult> Index()
    {
        return View();
    }
}
