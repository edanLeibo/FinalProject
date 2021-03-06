﻿namespace FinalProject.Migrations
{
    using EX5.Models;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalProject.Dal.GeneralDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FinalProject.Dal.GeneralDbContext";
        }

        protected override void Seed(FinalProject.Dal.GeneralDbContext context)
        {

            context.DBCategories.AddOrUpdate(x => x.CategoryID,
               new Category() { CategoryID = 1, CategoryName = "Food" },
               new Category() { CategoryID = 2, CategoryName = "Construction" },
               new Category() { CategoryID = 3, CategoryName = "Fashion" },
               new Category() { CategoryID = 4, CategoryName = "Internet" },
               new Category() { CategoryID = 5, CategoryName = "Kitchen" },
               new Category() { CategoryID = 6, CategoryName = "Music" }
            );

           context.DBBusiness.AddOrUpdate(x => x.BusinessID,
            new Business() { BusinessID = 1, BusinessName = "Cafe Cafe", CategoryID = 1, StreetAddress = "12 Hashalom st.", City = "Haifa", Website = "www.cafecafe.co.il", Description = "One of the most successful coffee houses in Israel, offering quality coffee and dairy food.", Owner = "David Colman", PhoneNumber = "04-4788322", AVGrank = 4.5 },
            new Business() { BusinessID = 2, BusinessName = "Cafe Joe", CategoryID = 1, StreetAddress = "15 Hahashmonaim st.", City = "Jerusalem", Website = "www.joe.co.il", Description = "The first international coffee house that opened a store in Israel. Famous for it's special smoothies.", Owner = "Rami Tamir", PhoneNumber = "02-5784455", AVGrank = 4 },
            new Business() { BusinessID = 3, BusinessName = "River", CategoryID = 1, StreetAddress = "111 Tishbi st.", City = "Tel Aviv", Website = "river-bar.co.il", Description = "A high quality noodels-bar, serves classical asian dishes with contemporary design.", Owner = "Moshe Levi" , PhoneNumber = "03-9234452", AVGrank = 3 },
            new Business() { BusinessID = 4, BusinessName = "Giraffe", CategoryID = 1, StreetAddress = "18 Samuel st.", City = "Haifa", Website = "www.giraffe.co.il", Description = "This restaurant offers a new twist to familiar dishes from all over the world.", Owner = "Peter Parker", PhoneNumber = "04-7567709", AVGrank = 3.2 },
            new Business() { BusinessID = 5, BusinessName = "Etzh", CategoryID = 2, StreetAddress = "32 Rotenberg st.", City = "Jerusalem", Website = "www.etzhashaked.co.il", Description = "Engaged in entrepreneurship, contracting and management of privately owned investments, with an emphasis on residential projects.", Owner = "Arad Nir", PhoneNumber = "02-6555902", AVGrank = 4.6 },
            new Business() { BusinessID = 6, BusinessName = "Adler", CategoryID = 2, StreetAddress = "14 King David st.", City = "Tel Aviv", Website = "www.adlers.co", Description = "Adler Construction specialized in the overall management of construction initiative projects, of any kind and at any scale.", Owner = "Yogev Ohayon", PhoneNumber = "03-9432211", AVGrank = 4 },
            new Business() { BusinessID = 7, BusinessName = "Shikun", CategoryID = 2, StreetAddress = "12 HaYarkon st.", City = "Haifa", Website = "www.shikunbinui.co.il", Description = "Israel’s leading infrastructure and real estate group. Involved in large-scale construction of residential neighborhoods and public buildings.", Owner = "Fred Rose", PhoneNumber = "04-9432211", AVGrank = 3.5 },
            new Business() { BusinessID = 8, BusinessName = "Africa", CategoryID = 2, StreetAddress = "114 Ben Gurion st.", City = "Jerusalem", Website = "www.africa-israel.co.il", Description = "An international holdings and investments group. It's active worldwide and focuses on projects of real-estate, construction, industry and hotels.", Owner = "Sarah Farmer", PhoneNumber = "02-4788322", AVGrank = 2.5 },
            new Business() { BusinessID = 9, BusinessName = "Golf", CategoryID = 3, StreetAddress = "28 Ratner st.", City = "Tel Aviv", Website = "www.golfgroup.co.il", Description = "A leading fashion company, specializing in both casual and elegant clothing for both men and women.", Owner = "Jenny Blake", PhoneNumber = "03-5784455", AVGrank = 4.8 },
            new Business() { BusinessID = 10, BusinessName = "Renuar", CategoryID = 3, StreetAddress = "50 Joe Alon st.", City = "Haifa", Website = "www.renuar.co.il", Description = "One of the top 5 fashon companies in Israel. Designing clothes for the whole family.", Owner = "Sivan Tadmor", PhoneNumber = "04-9234452", AVGrank = 2.3 },
            new Business() { BusinessID = 11, BusinessName = "Lacoste", CategoryID = 3, StreetAddress = "20 Antebe st.", City = "Jerusalem", Website = "global.lacoste.com", Description = "A newly opened high quality fashion store. With clothes to fit any size and any style.", Owner = "Loren Bowman", PhoneNumber = "02-7567709", AVGrank = 3.2 },
            new Business() { BusinessID = 12, BusinessName = "Castro", CategoryID = 3, StreetAddress = "63 Hazal st.", City = "Tel Aviv", Website = "www.castro.com", Description = "A fashion store for all ages. With a variety of styles to fit any occation.", Owner = "Henry Ford", PhoneNumber = "03-4788322", AVGrank = 3.4 },
            new Business() { BusinessID = 13, BusinessName = "Partner", CategoryID = 4, StreetAddress = "16 Herzog st.", City = "Haifa", Website = "www.partner.co.il", Description = "A leading internet company. Offers high-speed internet connection for low prices", Owner = "Shira Marom", PhoneNumber = "04-5784455", AVGrank = 3.3 },
            new Business() { BusinessID = 14, BusinessName = "Netvision", CategoryID = 4, StreetAddress = "2 Dori st.", City = "Jerusalem", Website = "netvision.cellcom.co.il", Description = "The first internet company in Israel. Offers free installtion and 'pay-as-you-go' payment planns.", Owner = "Matan Navon", PhoneNumber = "02-9234452", AVGrank = 2 },
            new Business() { BusinessID = 15, BusinessName = "TripleC", CategoryID = 4, StreetAddress = "21 Shazar st.", City = "Tel Aviv", Website = "www.ccc.co.il", Description = "A new internet company, offers internet as well as phone and TV services.", Owner = "Rinat Avraham", PhoneNumber = "03 - 7567709", AVGrank = 4.1 },
            new Business() { BusinessID = 16, BusinessName = "Hot", CategoryID = 4, StreetAddress = "18 Adar st.", City = "Haifa", Website = "www.hot.net.il", Description = "An internet company which serves more than half of Israel’s internet users.", Owner = "Meni Beger", PhoneNumber = "04-7567709", AVGrank = 3.2 }
        );

            context.DBReview.AddOrUpdate(x => x.ReviewID,
                new Review() { ReviewID = 1, BusinessID = 1, Author = "Dan Levin", Date = new DateTime(2016, 1, 1), Description = "Me and My husband went there to celebrate our 50th anniversary. It was so romantic, the food was great and the staff was very nice. We had a great time!" },
                new Review() { ReviewID = 2, BusinessID = 1, Author = "Avi Noy", Date = new DateTime(2016, 2, 2), Description = "I ordered the pasta napolitana dish and it came out after 30 minutes, cold, dry and over salted. Disappointment" },
                new Review() { ReviewID = 3, BusinessID = 1, Author = "David Ford", Date = new DateTime(2017, 1, 3), Description = "My friend recommended me about this place, I had a lovely meal and a great coffee." },
                new Review() { ReviewID = 4, BusinessID = 2, Author = "Rachel Back", Date = new DateTime(2017, 2, 4), Description = "I had hot, fresh baked bread stuffed with cheese and spinach, and a side of herbed carrot salad. Both were so amazingly delicious! Nice staff, convenient location!" },
                new Review() { ReviewID = 5, BusinessID = 2, Author = "Linoi David", Date = new DateTime(2016, 5, 5), Description = "Our entire family went there for a celebration dinner and we were so awfully disappointed!! Most of the food took quite some time in arriving and most of the dishes were only mediocre at best." },
                new Review() { ReviewID = 6, BusinessID = 2, Author = "Angie Collins", Date = new DateTime(2016, 6, 6), Description = "I loved this place. So special and simple. They helped recommend which dishes to get. So impressed with the quality of food for the low price." },
                new Review() { ReviewID = 7, BusinessID = 3, Author = "Brook Levi", Date = new DateTime(2017, 2, 7), Description = "We had a great dinner here with a food plate to share and it was delicious. The staff is very friendly and the lay back TLV atmosphere is contagious. Well be back soon." },
                new Review() { ReviewID = 8, BusinessID = 3, Author = "Bob Stone", Date = new DateTime(2017, 4, 8), Description = "This is an excellent place to eat. Everything here is good: the staff, the food, the environment. It was very neat and clean. I was with my friends there and we really enjoyed our meal." },
                new Review() { ReviewID = 9, BusinessID = 3, Author = "Libi Brown", Date = new DateTime(2016, 9, 9), Description = "Excellent food, super service, we could even store our luggage. Lovely garden. Our first choice place in Tel Aviv. Thanks!" },
                new Review() { ReviewID = 10, BusinessID = 4, Author = "Joe Alon", Date = new DateTime(2016, 10, 10), Description = "Extensive breakfast, very lovely and tasty dishes such as the local shaksuka, various local breads and salads. Coffee was not good.... service was slow" },
                new Review() { ReviewID = 11, BusinessID = 4, Author = "Nora Jones", Date = new DateTime(2017, 5, 11), Description = "We were attracted to this restaurant by the classy décor, unfortunately the food was not so good. Our fish was overcooked and the vegetables mediocre." },
                new Review() { ReviewID = 12, BusinessID = 4, Author = "Ruth Walker ", Date = new DateTime(2017, 6, 12), Description = "It was a wonderful evening at Giraffe. Champagne, appetizers, cheese and wine were so amazing... Enjoyed it very much!" },
                new Review() { ReviewID = 13, BusinessID = 5, Author = "Jason Brooks", Date = new DateTime(2016, 11, 13), Description = "Just completed a remodel with an addition and it came out awesome. Me and my wife Beth were so pleased with everything, we can't believe it's our house." },
                new Review() { ReviewID = 14, BusinessID = 5, Author = "Tamara Blaze", Date = new DateTime(2016, 12, 14), Description = "They did a great job with our house, highly recommended!  They did our bathroom, floors, lights as well as some electrical work.  Great price and friendly, and very trustworthy." },
                new Review() { ReviewID = 15, BusinessID = 5, Author = "Fredd Morison", Date = new DateTime(2017, 7, 15), Description = "I used their services for a rather small project. They did a great job and asked for a fair price." },
                new Review() { ReviewID = 16, BusinessID = 6, Author = "static@gmail.com", Date = new DateTime(2017, 8, 16), Description = "My father's house needed adaptation for a wheel chair. I wasn't an easy task however they managed to ace it and now my father can move freely through house." },
                new Review() { ReviewID = 17, BusinessID = 6, Author = "Rob Winner", Date = new DateTime(2016, 1, 17), Description = "Do not use Adler under any circumstances! They did a small job for me many years ago that had one of their employees working for a little over a week and charged an outrageous amount of money." },
                new Review() { ReviewID = 18, BusinessID = 6, Author = "Natasha Lee", Date = new DateTime(2016, 2, 18), Description = "I contacted them online, and they immediately called me and set up an appointment to come and see the property. We settled for a fair price and a date to start working. I'm very pleased with the outcome." },
                new Review() { ReviewID = 19, BusinessID = 7, Author = "Liran Alpert", Date = new DateTime(2017, 1, 19), Description = "On time with great passion for their job. Gives honest opinions on the best way to solve an issue without the big expense." },
                new Review() { ReviewID = 20, BusinessID = 7, Author = "Mina Kolton", Date = new DateTime(2017, 2, 20), Description = "I wouldn't recommend this company. I wanted to hire them to renovate a three-room apartment. They asked for a very high price with no justification." },
                new Review() { ReviewID = 21, BusinessID = 7, Author = "Kirsten Asher", Date = new DateTime(2016, 3, 21), Description = "My friend recommended using their services. After seeing the property, they gave me a price offer which I signed and they started working. Very high work ethics, attention to details and proffesionality." },
                new Review() { ReviewID = 22, BusinessID = 8, Author = "Asher Kugman", Date = new DateTime(2016, 4, 22), Description = "The work is beautifully done and the employees are very conscientious of the property and the owner.  I'd definitely use them again and recommend them." },
                new Review() { ReviewID = 23, BusinessID = 8, Author = "Mali Mor", Date = new DateTime(2017, 3, 23), Description = "Number one construction company! I will definitely recommend my friends and family to use their services." },
                new Review() { ReviewID = 24, BusinessID = 8, Author = "Moran Cabel", Date = new DateTime(2017, 4, 24), Description = "I am a property manager and have used this service several times.  Our office is very pleased with thier service and eye for detail in their finish work." },
                new Review() { ReviewID = 25, BusinessID = 9, Author = "Itzik Fridman", Date = new DateTime(2016, 5, 25), Description = "I bought a red dress through their website. The dress arived after 2 days, with a delivery guy. Great service!" },
                new Review() { ReviewID = 26, BusinessID = 9, Author = "Shaked Hadar", Date = new DateTime(2016, 6, 26), Description = "I visited the store in Tel-Aviv on suterday morning. The place was so crowded, it was impossible to try on clothes since the queue to the fitting room was endles! Didn't buy anything at the end... " },
                new Review() { ReviewID = 27, BusinessID = 9, Author = "Hadas Talmon", Date = new DateTime(2017, 5, 27), Description = "I went to buy a dress for my sisters wedding. The saleswoman was very nice and patient. I ended up buying a dress for myself and returned the day after with my mother and she bought a dress too." },
                new Review() { ReviewID = 28, BusinessID = 10, Author = "Ofir Luz", Date = new DateTime(2017, 6, 28), Description = "My friend gave me a gift card for Golf for my birthday. I bought myself two skirts, a summer hat and a jacket. Best gift ever!" },
                new Review() { ReviewID = 29, BusinessID = 10, Author = "Nisim Halabi", Date = new DateTime(2016, 7, 29), Description = "I bought a T-shirt for my boyfriend and came back the day after to exchange it because the size was wrong. They didn't have the size I needed so the salesman ordered it and said he would call me when the shirt arrives. Two days later I got a phone call from him. Couldent ask for better service." },
                new Review() { ReviewID = 30, BusinessID = 10, Author = "Victor Ford", Date = new DateTime(2016, 8, 1), Description = "I passed by and couldn't resist getting in to see the new collection. Amazing stuff! I bought three T's, a couple of shorts and a necklace. And all for a great price." },
                new Review() { ReviewID = 31, BusinessID = 11, Author = "Blake Horton", Date = new DateTime(2017, 7, 2), Description = "My son is celebtating his Bar-Mizvah next month. We mangaged to find clothes for all of us - me, my husband, our son and three daughters. Great place." },
                new Review() { ReviewID = 32, BusinessID = 11, Author = "Julia Bonen", Date = new DateTime(2017, 8, 3), Description = "After searching for weeks, I finally found my dream wedding dress. Who would believe??" },
                new Review() { ReviewID = 33, BusinessID = 11, Author = "Meni London", Date = new DateTime(2016, 9, 4), Description = "I don't understand why everyone are so excited about this store. High prices, low quality and bad service." },
                new Review() { ReviewID = 34, BusinessID = 12, Author = "Michal Atias", Date = new DateTime(2016, 10, 5), Description = "This is my go-to store whenever I need somthing to wear for a special occation." },
                new Review() { ReviewID = 35, BusinessID = 12, Author = "Dana Mazor", Date = new DateTime(2017, 1, 6), Description = "So happy that they're oppening another store in Eilat! I used to order online and have it sent to my house. Now I can go and try on the stuff I buy." },
                new Review() { ReviewID = 36, BusinessID = 12, Author = "Ariel Meir", Date = new DateTime(2017, 2, 7), Description = "Only two salesmen in the whole store! Can't find what you need and not enough people to assist." },
                new Review() { ReviewID = 37, BusinessID = 13, Author = "Ben King", Date = new DateTime(2016, 11, 8), Description = "My internet connection is so slow, I'm seriously considering moving to another company." },
                new Review() { ReviewID = 38, BusinessID = 13, Author = "Amnon Hadad", Date = new DateTime(2016, 12, 9), Description = "I just found out that they are still charging me even though I disconnected 5 month ago. When I try to call them, there is waiting time of 1 hour! I don't know what to do.." },
                new Review() { ReviewID = 39, BusinessID = 13, Author = "Tal Akiva", Date = new DateTime(2017, 3, 10), Description = "They offer a very attractive payment plan. I had a bad experience with another company, hope this one will be better." },
                new Review() { ReviewID = 40, BusinessID = 14, Author = "Yael Tal", Date = new DateTime(2017, 4, 11), Description = "Such a rip-off! They promised me 100Mb however I hardly get 40Mb." },
                new Review() { ReviewID = 41, BusinessID = 14, Author = "Dorit Reuven", Date = new DateTime(2016, 1, 12), Description = "Great service, helpful tips on managing high data throughput, low prices and high speed." },
                new Review() { ReviewID = 42, BusinessID = 14, Author = "Ross Graham", Date = new DateTime(2016, 2, 13), Description = "I wish I found this company earlier. I'm very pleased with my internet connection." },
                new Review() { ReviewID = 43, BusinessID = 15, Author = "Reuven Cole", Date = new DateTime(2017, 5, 14), Description = "I took the triple - internet, phone and TV. I have some problems with the phone however the internet connection was never better." },
                new Review() { ReviewID = 44, BusinessID = 15, Author = "Nir Arad", Date = new DateTime(2017, 6, 15), Description = "We moved from our old apartment to a bigger home and needed installation of new access points. They schedueled a technician for the day of the move and charged a fair price." },
                new Review() { ReviewID = 45, BusinessID = 15, Author = "Dudu Zohar", Date = new DateTime(2016, 3, 16), Description = "They accidentaly overcharged us and when we notified them about the mistake they immediately returned our money and deeply appolegized. However if we wouldn't have noticed... who knows how much money we could have paid for nothing." },
                new Review() { ReviewID = 46, BusinessID = 16, Author = "Shalom Cohen", Date = new DateTime(2016, 4, 17), Description = "Our internet connection has never been better. The lady at the customer service offered using a cable instead of Wi-Fi and the improvement in the speed is very noticeable." },
                new Review() { ReviewID = 47, BusinessID = 16, Author = "Sarah Bright", Date = new DateTime(2017, 7, 18), Description = "The technician that came to install the connection points was very proffesional and nice. He did a clean and asthetic work." },
                new Review() { ReviewID = 48, BusinessID = 16, Author = "Tova Lipshiz", Date = new DateTime(2017, 8, 19), Description = "My son accidentaly broke the rauter. They sent us a new rauter with delivery to our door-step. Great service!" },
                new Review() { ReviewID = 49, BusinessID = 16, Author = "Jenny Rorik", Date = new DateTime(2016, 5, 20), Description = "Very rude customer service! It took them 30 minutes to answer my call and they didn't even help." }
          );

            context.DBOffice.AddOrUpdate(x => x.OfficeID,
                new Office() { OfficeID = 1, Manager = "Angelina Folie", City = "Haifa", Street = "Herzl", HouseNumber = "10", Latitude = 32.812452, Longitude = 34.996451 },
                new Office() { OfficeID = 2, Manager = "Brady Pitty", City = "Tel Aviv- Jaffa", Street = "Ibn Gabirol", HouseNumber = "124", Latitude = 32.086956, Longitude = 34.782392 },
                new Office() { OfficeID = 3, Manager = "Jenni Love Kiwi", City = "Jerusalem", Street = "Jaffa", HouseNumber = "52", Latitude = 31.783242, Longitude = 35.217728 },
                new Office() { OfficeID = 4, Manager = "Michael Yarden", City = "Beer Sheva", Street = "Yitzhak Rager", HouseNumber = "39", Latitude = 31.251601, Longitude = 34.798025 },
                new Office() { OfficeID = 5, Manager = "Monica Clinton", City = "Tiberias", Street = "Michael", HouseNumber = "22", Latitude = 32.794648, Longitude = 35.532391 },
                new Office() { OfficeID = 6, Manager = "Adam Cohen", City = "Eilat", Street = "Los Angeles", HouseNumber = "58", Latitude = 29.560059, Longitude = 34.941117 },
                new Office() { OfficeID = 7, Manager = "Khloé Kardashian", City = "Ashkelon", Street = "Kislev", HouseNumber = "46", Latitude = 31.673538, Longitude = 34.580925 }
                 );

        }
    }
}
