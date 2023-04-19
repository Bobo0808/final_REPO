using final_repo_test.Interfaces;
using final_repo_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.DebugLogs.Controllers
{
    [Area("DebugLog")]
    public class DebugLog_HomeController : Controller
    {
        private readonly IDebugLogRepository _debugLogRepository;
        public DebugLog_HomeController(IDebugLogRepository debugLogRepository)
        {
            _debugLogRepository = debugLogRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<DebugLog> debugLogs = await _debugLogRepository.GetAll();
            return View(debugLogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Console.WriteLine(id);
            DebugLog debugLog = await _debugLogRepository.GetIdAsync(id);
            return View(debugLog);
        }

        public async Task<IActionResult> Edit(int id)
        {
            DebugLog debugLogs = await _debugLogRepository.Edit(id);
            _debugLogRepository.Update(debugLogs);
            return RedirectToAction("Index");
        }
    }
}
