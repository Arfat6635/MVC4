using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        TaskEntities taskEntities = new TaskEntities(); 
        public ActionResult Index()
        {
           var result = context.AddBooks.ToList();
            return View();
        }

        public ActionResult About(LoginModel loginModel)
        {

            ViewBag.Message = "Your application description page.";

            var result = taskEntities.Student_tbl.ToList();

            return View(result);
        }

        public ActionResult Contact()
        {
            List<BookModel> bookModels = new List<BookModel>() {
                new BookModel{imagePath = "../images/1.jpg",Title="The Adventures of animal",Author="Hannah Kaner",price="100",BookID="1"},
                new BookModel{imagePath = "../images/2.jpg",Title="Better by far",Author="James Carlson",price="230",BookID="2"},
                new BookModel{imagePath = "../images/3.jpg",Title="The end of drum time",Author="Unknown",price="430",BookID="3"},
                new BookModel{imagePath = "../images/4.jpg",Title="The East Indian",Author="Abhijit Patel",price="340",BookID="4"},
                new BookModel{imagePath = "../images/5.jpg",Title="Secret book of flora lea",Author="Flora Lea",price="120",BookID="5"},
                new BookModel{imagePath = "../images/6.jpg",Title="You'D look better as a ghost",Author="",price="540",BookID="6"},
                new BookModel{imagePath = "../images/7.jpg",Title="Quentim Tarantimo cinema speculation",Author="Hannah Baker",price="20",BookID="7"},
                new BookModel{imagePath = "../images/8.jpg",Title="Light Bringer",Author="Arnold",price="540",BookID="8"},
                new BookModel{imagePath = "../images/9.jpg",Title="Trees of the emerald",Author="Emerald Chi",price="10",BookID="9"},
                new BookModel{imagePath = "../images/10.jpg",Title="The god of endings",Author="Unknown",price="1340",BookID="10"},
                new BookModel{imagePath = "../images/11.jpg",Title="The Last Animal",Author="Ramona Ausubel",price="150",BookID="10"}
            };
            ViewBag.Message = "Please select a book";
            return View(bookModels);
        }

        [HttpPost]
        public ActionResult Contact(string bookID)
        {
            string ID = bookID;
            return RedirectToAction("Index");
        }

        public ActionResult Save()
        {

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Save(LoginModel login)
        {
            if (ModelState.IsValid)                                                                                                                                                   
            {
                
            }

            return RedirectToAction("Index");
        }
    }
}