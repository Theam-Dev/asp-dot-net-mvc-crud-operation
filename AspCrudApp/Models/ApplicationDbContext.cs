using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AspCrudApp.Models;

namespace AspCrudApp.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Post> Post { get; set; }
    }
}