using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //public ViewResult Index() => View(DateTime.Now);
        //использование для передачи даних обьекта ViewBag плюс в том что можно с легкостью передать много обьектов 
        public ViewResult WorkViewBag()
        {
            ViewBag.Date = DateTime.Now.TimeOfDay;
            ViewBag.Massage = $"hello Neo";
            return View();
        }
        public RedirectResult Redirect() => Redirect("Example/Index");
        public RedirectToActionResult Redirection() => RedirectToAction("Headers", "Derived");
        //отправка в ответе Json файл
        //public JsonResult Index() => Json(new[] { "alice", "bob", "sasha" });
        //Отправка обьекта в ответе
        //public ObjectResult Index() => Ok(new string[] { "alice", "bob", "sasha" });
        //Отправка файла 
        //public VirtualFileResult Index() => File("path to file", "text/css");
    }
}
