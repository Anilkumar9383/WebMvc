using FirstWebMvc.Interface;
using FirstWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstWebMvc.Controllers
{
    public class HomeController : Controller
    {

        public ILogin _newLog;
        public HomeController(ILogin newLog)
        {
            _newLog = newLog;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(LoginData loginData)
        {
            var Result = await _newLog.UpdateLoginData(loginData);
            return View(Result);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginData loginData)
        {
            if(ModelState.IsValid)
            {
                 await _newLog.AddLoginData(loginData);
                 return View("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> LoginResult()
        {
            var data = await _newLog.GetLoginDatas();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var Result = await _newLog.GetLoginData(id);
            return View(Result);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var Result = await _newLog.GetLoginData(id);
            return View(Result);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _newLog.DeleteLoginData(id);
            return RedirectToAction("LoginResult");
        }

        public IActionResult ExploreNow()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}