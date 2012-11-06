using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject.Modules;
using Ninject_Test.Services;

namespace Ninject_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService MessageService;

        public HomeController(IMessageService welcomeMessageService)
        {
            this.MessageService = welcomeMessageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = this.MessageService.MonkeyMessage();
            return View();
        }
    }

}
