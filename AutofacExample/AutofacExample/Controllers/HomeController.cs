using AutofacExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacExample.Controllers
{
    public class HomeController : Controller
    {
        IService _Service;
        IMailService _MailService;
        IProduct _ProductService;
        public HomeController(IService Service, IMailService mailService, IProduct productService)
        {
            _Service = Service;
            _MailService = mailService;
            _ProductService = productService;
        }
        // GET: Home
        public ActionResult Index()
        {
            string isMailValid = _MailService.CheckdMail("kevser.yolcu@piworks.net");
            ViewBag.Name = _Service.Execute("kevser", "yolcu");
            ViewBag.IsMailValid = isMailValid;
            var model = _ProductService.GetAllProduct();
            return View(model);
        }
    }
}