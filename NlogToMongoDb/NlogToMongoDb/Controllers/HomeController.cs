using Microsoft.AspNetCore.Mvc;
using NLog;
using NLog.Fluent;

namespace NlogToMongoDb.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public IActionResult Index()
        {
            _logger.Debug("DebugLog");
            _logger.Trace("TraceLog");
            _logger.Error("ErrorLog");
            _logger.Fatal("FatalLog");
            _logger.Info("InfoLog");
            _logger.Warn("WarnLog");

            _logger.Info()
                .Message("MessageLog")
                .Property("testpro", "properties")
                .Write();

            return View();
        }
    }
}
