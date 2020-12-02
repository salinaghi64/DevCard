

using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>()
            {
                new Project(1,"تاکسی","درخواست آنلاین تاکسی","project-1.jpg","Snapp"),
                new Project(2,"زود فود","درخواست آنلاین  غذا برای سراسر کشور","project-2.jpg","ZoodFood"),
                new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس ","project-3.jpg","Monop"),
                new Project(4,"تاکسی","برنامه مدیریت فضا پیما ناسا","project-4.jpg","NASA"),

                                                                                                                 


            };


            return View("_Projects", projects);
        }
        
    }
}
