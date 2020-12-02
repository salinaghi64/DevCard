

using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()


        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش asp.net core Mvc", "کاملترین آموزش ASP.net core به زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "Git,Github آموزش ", "کاملترین آموزش Git,Github",
                "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش C#", "کاملترین آموزش C# به زبان فارسی",
                "blog-post-thumb-card-3.jpg"),
                new Article(1, "آموزش طراحی سایت", "کاملترین آموزش طراحی سایت به زبان فارسی",
                "blog-post-thumb-card-4.jpg")

            };


            return View("LatestArticles", articles);
        }
    }
}
