using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data1 = "BLOG";
            ViewBag.data2 = "Bloglar";
            return View();
        }
        public IActionResult Details(int id) 
        {
            ViewBag.blogId = id;
            return View();
        } 
    }
}
