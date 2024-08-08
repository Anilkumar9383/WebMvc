using first_mvc.Interface;
using FirstWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMvc.Controllers
{
    public class SignUpController : Controller
    {
        public FirstInterface NewSignup;
        public SignUpController(FirstInterface newSignup)
        {
            NewSignup = newSignup;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpData signup)
        {
            await NewSignup.AddSignUpData(signup);
            return RedirectToAction("SignUpResult");
        }

        [HttpGet]
        public async Task<IActionResult> SignUpResult()
        {
            var data = await NewSignup.GetSignUpDatas();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SignUpData signup)
        {
            await NewSignup.UpdateSignUpData(signup);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var signupdata = await NewSignup.GetSignUpData(Id);
            return View(signupdata);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var details = await NewSignup.GetSignUpData(id);
            return View(details);

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await NewSignup.DeleteSignUpData(id);
            return RedirectToAction("SignUpResult");
        }
    }
}
       /* private InterfaceGeneric<SignUpData> repository = null;
        public SignUpController()
        {
            this.repository = new GenericRepository<SignUpData>();
        }
        public SignUpController(InterfaceGeneric<SignUpData> repository)
        {
            this.repository = repository;
        }*/
        /*  [HttpGet]
          public ActionResult Index()
          {
              var model = repository.GetAll();
              return View(model);
          }
          [HttpGet]
          public ActionResult AddEmployee()
          {
              return View();
          }
          [HttpPost]
          public ActionResult AddEmployee(SignUpData model)
          {
              if (ModelState.IsValid)
              {
                  repository.Insert(model);
                  repository.Save();
                  return RedirectToAction("Index", "Employee");
              }
              return View();
          }
          [HttpGet]
          public ActionResult EditEmployee(int ID)
          {
              SignUpData model = repository.GetById(ID);
              return View(model);
          }
          [HttpPost]
          public ActionResult EditEmployee(SignUpData model)
          {
              if (ModelState.IsValid)
              {
                  repository.Update(model);
                  repository.Save();
                  return RedirectToAction("Index", "Employee");
              }
              else
              {
                  return View(model);
              }
          }
          [HttpGet]
          public ActionResult DeleteEmployee(int ID)
          {
              SignUpData model = repository.GetById(ID);
              return View(model);
          }
          [HttpPost]
          public ActionResult Delete(int ID)
          {
              repository.Delete(ID);
              repository.Save();
              return RedirectToAction("Index", "Employee");
          }*/
