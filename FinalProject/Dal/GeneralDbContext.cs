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
        public DbSet<User> DBUser { get; set; }
        public DbSet<Business> DBBusiness { get; set; }
        public DbSet<Rank> DBRank { get; set; }
        public DbSet<Office> DBOffice { get; set; }    }
}
