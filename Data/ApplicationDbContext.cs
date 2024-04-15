using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext():base("Connstr") //Pass the connectionstring name from config
        {
            //Set the Initializer
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        public  DbSet<AddBook> AddBooks { get; set; }
        
    }
}