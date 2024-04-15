using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class BookModel
    {
        public string imagePath { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string price { get; set; }

        public string BookID { get; set; }
    }
}