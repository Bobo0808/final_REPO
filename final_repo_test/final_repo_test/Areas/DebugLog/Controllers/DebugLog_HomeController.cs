using final_repo_test.Interfaces;
using ClassLibrary.Models;
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

      

        public async Task<IActionResult> Edit(int id)
        {
            DebugLog debugLogs = await _debugLogRepository.Edit(id);
            _debugLogRepository.Update(debugLogs);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete()
        {
            IEnumerable<DebugLog> debugLogs = await _debugLogRepository.DeleteIsSolved();
            _debugLogRepository.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            DebugLog debugLog = await _debugLogRepository.GetIdAsync(id);
            return View(debugLog);
        }


        [HttpPost]
        public async Task<IActionResult> Detail(DebugLog debugLog)
        {
            var temp = await _debugLogRepository.GetIdAsync(debugLog.D_ID);
            if(temp!= null)
            {
                temp.D_Comment = debugLog.D_Comment;
                _debugLogRepository.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            
        }
    }
}
