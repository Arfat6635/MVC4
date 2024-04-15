using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CreateBookController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: CreateBook
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Save(AddBook book)
        {
            if (ModelState.IsValid) {
                context.AddBooks.Add(book);
              int result =   context.SaveChanges();

                string Message = result == 0 ? "Insertion Failed" : "Inserted Successfully!";
                TempData["Message"]=Message;

                
            }
            return RedirectToAction("Create");
        }
    }
}