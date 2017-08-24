namespace FinalProject.Migrations
{
    using EX5.Models;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalProject.Dal.GeneralDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalProject.Dal.GeneralDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //  if (!(context.Users.Any(u => u.UserName == "Admin@gmail.com")))
            //  {
            //      var userStore = new UserStore<ApplicationUser>(context);
            //      var userManager = new UserManager<ApplicationUser>(userStore);
            //      var userToInsert = new ApplicationUser { UserName = "Admin@gmail.com", PhoneNumber = "038723211" };
            //      userManager.Create(userToInsert, "Edan1!");
            //  }
            context.DBBusiness.AddOrUpdate(x => x.BusinessID,
            new Business() { BusinessID=1,Type="Food", Address="12/2 HaYarkon st. Tel Aviv", Website= "www.cafeJoe.co.il", Photo="", Description="Coffee bar", Owner="Yogev Ohayon", BusinessName="Cafe Joe", Video="",PhoneNumber="03-9432211"},
            new Business() { BusinessID = 1, Type = "Food", Address = "12/2 Hashalom st. Haifa", Website = "www.cafecafe.co.il", Photo = "", Description = "Coffee bar", Owner = "David Colman", BusinessName = "CafeCafe", Video = "", PhoneNumber = "03-4788322" },
            new Business() { BusinessID = 2, Type = "Food", Address = "15/1 Hahashmonaim st. Jerusalem", Website = "www.shufersal.co.il", Photo = "", Description = "The largest supermarket chain in Israel", Owner = "Rami Tamir", BusinessName = "Shufersal", Video = "", PhoneNumber = "08-5784455" },
            new Business() { BusinessID = 3, Type = "Internet", Address = "111/32 Tishbi st. Sderot", Website = "www.wix.co.il", Photo = "", Description = "A cloud-based web development platform that was first developed and popularized", Owner = "Moshe Levi", BusinessName = "Wix", Video = "", PhoneNumber = "02-9234452" },
            new Business() { BusinessID = 4, Type = "Construction", Address = "18/6 Samuel st. Tel Aviv", Website = "www.turnerconstruction.com", Photo = "", Description = "An American construction company, one of the largest construction management companies in the USA ", Owner = "Peter J. Davoren", BusinessName = "Turner Construction Company", Video = "", PhoneNumber = "03-7567709" },
            new Business() { BusinessID = 5, Type = "Construction", Address = "192/32 Rotenberg st. Ra'anana", Website = "www.accsal.com", Photo = "", Description = "Coffee bar", Owner = "Rami Cohen", BusinessName = "Accsal Construction", Video = "", PhoneNumber = "03-6555902" }
          );
        }
    }
}
