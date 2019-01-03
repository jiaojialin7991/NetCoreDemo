using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreDemo.Models;
using Microsoft.Extensions.Options;

namespace MyNetCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly Content contents;
        public HomeController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {         
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult TestDemo()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}

            //return View(new ContentViewModel { Contents = contents });

            List<Content> list = new List<Content>();
            list.Add(contents);

            return View(new ContentViewModel { Contents = list });
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
