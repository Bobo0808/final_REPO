using final_repo_test.Data;
using final_repo_test.Interfaces;
using final_repo_test.ViewModels.LoginStatus;
using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Areas.LoginStatus.Controllers
{
    [Area("LoginStatus")]


    public class LoginStatus_HomeController : Controller
    {
        private readonly ILoginStatusRepository _loginStatusRepository;
        public LoginStatus_HomeController(ILoginStatusRepository loginStatusRepository)
        {
            _loginStatusRepository = loginStatusRepository;
        }
        public async Task<IActionResult> Index(string Chart = "Day")
        {
            GetDayViewModel data = await _loginStatusRepository.GetDay(Chart);
            return View(data);
        }
    }
}
