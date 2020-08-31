using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");
        // первый вариант получения даных формы из контекста
        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //Упрощенный вариант
        //public ViewResult ReceiveForm(string name, string city)
        //{
        //    return View("Result", $"{name} lives in {city}");
        //}
        //Генерация ответа с использованием даных контекста (так работает за кулисами)
        //public void ReceiveForm(string name, string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    byte[] content = Encoding.ASCII.GetBytes($"<html><body>{name} lives in {city}</body>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}
        public IActionResult ReceiveForm(string name, string city) => new CustomHtmlResult { Content = $"{name} lives in {city}" };
    }
}
