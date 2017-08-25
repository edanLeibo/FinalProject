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
            new Business() { BusinessID = 6, Type = "Food", StreetAddress = "12/2 HaYarkon st.", City = "Tel Aviv", Website = "www.cafeJoe.co.il", Photo = "", Description = "Coffee bar", Owner = "Yogev Ohayon", BusinessName = "Cafe Joe", Video = "", PhoneNumber = "03-9432211" , AVGrank=4.4},
            new Business() { BusinessID = 1, Type = "Food", StreetAddress = "12/2 Hashalom st.", City = "Haifa", Website = "www.cafecafe.co.il", Photo = "", Description = "Coffee bar", Owner = "David Colman", BusinessName = "CafeCafe", Video = "", PhoneNumber = "03-4788322" , AVGrank = 3.4 },
            new Business() { BusinessID = 2, Type = "Food", StreetAddress = "15/1 Hahashmonaim st.", City = "Jerusalem", Website = "www.shufersal.co.il", Photo = "", Description = "The largest supermarket chain in Israel", Owner = "Rami Tamir", BusinessName = "Shufersal", Video = "", PhoneNumber = "08-5784455", AVGrank = 2.4 },
            new Business() { BusinessID = 3, Type = "Internet", StreetAddress = "111/32 Tishbi st.", City = "Sderot", Website = "www.wix.co.il", Photo = "", Description = "A cloud-based web development platform that was first developed and popularized", Owner = "Moshe Levi", BusinessName = "Wix", Video = "", PhoneNumber = "02-9234452", AVGrank=2 },
            new Business() { BusinessID = 4, Type = "Construction", StreetAddress = "18/6 Samuel st.", City = "Tel Aviv", Website = "www.turnerconstruction.com", Photo = "", Description = "An American construction company, one of the largest construction management companies in the USA ", Owner = "Peter J. Davoren", BusinessName = "Turner Construction Company", Video = "", PhoneNumber = "03-7567709",AVGrank=3.2},
            new Business() { BusinessID = 5, Type = "Construction", StreetAddress = "192/32 Rotenberg st.", City = "Ra'anana", Website = "www.accsal.com", Photo = "", Description = "Coffee bar", Owner = "Rami Cohen", BusinessName = "Accsal Construction", Video = "", PhoneNumber = "03-6555902", AVGrank=4.6}
          );


            context.DBOffice.AddOrUpdate(x => x.OfficeID,
                new Office() { OfficeID = 1, Manager = "Angelina Jolie", City = "Haifa", Street = "Herzl", HouseNumber = "10", Latitude = 32.812452, Longitude = 34.996451 },
                new Office() { OfficeID = 2, Manager = "Brad Pitt", City = "Tel Aviv- Jaffa", Street = "Ibn Gabirol", HouseNumber = "124", Latitude = 32.086956, Longitude = 34.782392 },
                new Office() { OfficeID = 3, Manager = "Jennifer Love Hewitt", City = "Jerusalem", Street = "Jaffa", HouseNumber = "52", Latitude = 31.783242, Longitude = 35.217728 },
                new Office() { OfficeID = 4, Manager = "Michael Jordan", City = "Beer Sheva", Street = "Yitzhak Rager", HouseNumber = "39", Latitude = 31.251601, Longitude = 34.798025 },
                new Office() { OfficeID = 5, Manager = "Hillary Clinton", City = "Tiberias", Street = "Michael", HouseNumber = "22", Latitude = 32.794648, Longitude = 35.532391 },
                new Office() { OfficeID = 6, Manager = "Adam Sandler", City = "Eilat", Street = "Los Angeles", HouseNumber = "58", Latitude = 29.560059, Longitude = 34.941117 },
                new Office() { OfficeID = 7, Manager = "Khloé Kardashian", City = "Ashkelon", Street = "Kislev", HouseNumber = "46", Latitude = 31.673538, Longitude = 34.580925 },
                new Office() { OfficeID = 8, Manager = "Kanye Omari West", City = "Afula", Street = "Shprinzak", HouseNumber = "233", Latitude = 32.610551, Longitude = 35.293307 },
                new Office() { OfficeID = 9, Manager = "Leonardo da Vinci ", City = "Kiryat Shmona", Street = "Arlozerov", HouseNumber = "67", Latitude = 33.207793, Longitude = 35.568489 }
                 );
        }
    }
}
