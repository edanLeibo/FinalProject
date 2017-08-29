using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EX5.Models;
using FinalProject.Models;

namespace FinalProject.Dal
{
    public class GeneralDbContext : DbContext
    {
        public DbSet<Business> DBBusiness { get; set; }
        public DbSet<Review> DBReview { get; set; }
        public DbSet<Office> DBOffice { get; set; }
        public DbSet<Category> DBCatagory { get; set; }
    }
}
