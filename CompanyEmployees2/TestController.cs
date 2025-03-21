using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees2;

[Route("[controller]")]
[ApiController]
public class TestController(ILoggerManager logger) : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        logger.LogInfo("Here is info message from our values controller.");
        logger.LogDebug("Here is debug message from our values controller.");
        logger.LogWarn("Here is warn message from our values controller.");
        logger.LogError("Here is an error message from our values controller.");
        return ["value1", "value2"];
    }
}