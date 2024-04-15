using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class CreateBookController : Controller
    {
        
        // GET: CreateBook
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}