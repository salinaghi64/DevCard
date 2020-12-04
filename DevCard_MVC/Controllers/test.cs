using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class test : Controller
    {
        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}

        //public  ContentResult Index()
        //{
        //    return Content("<h1>welcome to my website</h1><script>confirm('this is my question')</script>","text/html");
        //}

        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //}

        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var FileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(FileByte, MediaTypeNames.Text.Plain, fileName);

        //}

        //public JsonResult Index()
        //{
        //    return Json(data: new
        //    {
        //        id = 25,
        //        name = "Mahmoud",
        //        job = "Technecian",
        //        site = "www.artica.org"

        //    });


        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam salam dostan')");
        //}

        //public class JavascriptResult : ContentResult
        //{
        //    public JavascriptResult(string data)
        //    {
        //        Content = data;
        //        ContentType = "application/javascript";
        //    }
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atriya.com/");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        public IActionResult Index()
        {
           // return  new OkResult();
           // return  new NotFoundResult();
          // return  new BadRequestResult();
         // return  new NoContentResult();
         return  new StatusCodeResult(500);
        }
    }
}
