using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class WInitializer : DropCreateDatabaseIfModelChanges<WContext>
    {
        protected override void Seed(WContext context)
        {
            List<User> _users = new List<User>()
            {
                new Employee() { Name = "Nurefşan", Surname = "Müsevitoğlu", Email = "musevitoglunurefsan@gmail.com", Password = "0000", Country = "USA", City = "San Francisco" },
                new Employee() { Name = "Zeynep Nur", Surname = "Öztürk", Email = "zeynepozturk@gmail.com", Password = "1111", Country = "UK", City = "Lond" },
                new Employee() { Name = "Mert", Surname = "Özerdem", Email = "mertozerdem@gmail.com", Password = "2222", Country = "Turkey", City = "İstanbul" },
                new Employee() { Name = "Batuhan", Surname = "Erarslan", Email = "batuhanerarslan@gmail.com", Password = "3333", Country = "Turkey", City = "Ankara" },

                new Employer() { CompanyName = "Tesla", 
                                 About = "Tesla’s mission is to accelerate the world’s transition to sustainable energy through increasingly affordable electric vehicles in addition to renewable energy generation and storage. California-based Tesla is committed to having the best-in-class in safety, performance, and reliability in all Tesla cars. There are currently over 275,000 Model S, Model X and Model 3 vehicles on the road worldwide. To achieve a sustainable energy future, Tesla also created infinitely scalable energy products: Powerwall, Powerpack and Solar Roof. As the world’s only vertically integrated energy company, Tesla continues to innovate, scale and reduce the costs of commercial and grid-scale systems, with the goal of ultimately getting us to 100% renewable energy grids.", 
                                 Email = "info@tesla.com", Password = "0123", Country = "USA", City = "San Francisco" },
                new Employer() { CompanyName = "Udemy", 
                                 About = "With a mission to improve lives through learning, Udemy is the online learning destination that helps students, businesses, and governments gain the skills they need to compete in today’s economy. More than 40 million students are mastering new skills from expert instructors teaching over 130,000 online courses in topics from programming and data science to leadership and team building. For companies, Udemy for Business offers an employee training and development platform with subscription access to 3,500+ courses, learning analytics, as well as the ability to host and distribute their own content. Udemy for Government is designed to upskill workers and prepare them for the jobs of tomorrow. Udemy is privately owned and headquartered in San Francisco with offices in Denver, Brazil, India, Ireland, and Turkey.", 
                                 Email = "info@udemy.com", Password = "1234", Country = "USA", City = "New York" },
                new Employer() { CompanyName = "Airbnb", 
                                 About = "Founded in August of 2008 and based in San Francisco, California, Airbnb is a trusted community marketplace for people to list, discover, and book unique accommodations around the world — online or from a mobile phone. Whether an apartment for a night, a castle for a week, or a villa for a month, Airbnb connects people to unique travel experiences, at any price point, in more than 33,000 cities and 192 countries. And with world-class customer service and a growing community of users, Airbnb is the easiest way for people to monetize their extra space and showcase it to an audience of millions.", 
                                 Email = "info@airbnb.com", Password = "2345", Country = "USA", City = "San Francisco" },
                new Employer() { CompanyName = "KiwiCo", 
                                 About = "KiwiCo is an innovative eCommerce company that sparks kids’ creativity and curiosity through offline and online materials and inspiration. We offer kids a delightful, engaging way to explore, create, and learn. We offer a subscription service that delivers curated hands-on projects to kids. We take great pride and ownership in the products we build and in the community of parents and kids we serve. We’re backed by leading investors and were named one of the “20 Startups to Watch” by Business Insider. Our offices are located within walking distance from Caltrain and downtown Mountain View.", 
                                 Email = "info@kiwico.com", Password = "3456", Country = "USA", City = "California" }
            };
            foreach (var user in _users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();

            List<Job> _jobs = new List<Job>()
            {
                new Job() { JobTitle = "Mobile App Developer",
                            JobDescription = "Our client, a leading ad-tech firm in NYC is seeking a strong Mobile Engineer that will focus on developing and maintaining enterprise mobile solutions to their existing online experience. The mobile engineer will support the design, development, and maintenance of software solutions on mobile platforms.", 
                            StartDate = new DateTime(2019, 12, 10), DueDate = new DateTime(2020, 1, 30) },
                new Job() { JobTitle = "Software Engineer", 
                            JobDescription = "Tesla is seeking a Full Stack Software Engineer to join our team and help build the next generation of authentication and authorization solutions for our service partners and customers. You will be challenged to design security focused apps with a prioritization on availability and fault tolerance to provide an outstanding customer experience.", 
                            StartDate = new DateTime(2019, 12, 1), DueDate = new DateTime(2019, 12, 30) },
                new Job() { JobTitle = "Mobile Engineer", 
                            JobDescription = "Tesla is currently seeking a Mobile Developer to join our IT Applications team in Fremont, CA. This position will be working with the Software Engineering team in Fremont, CA. Tesla Internal applications are homegrown and tightly integrated with each other - Elon Musk says our services and applications take Tesla to \"Warp Speed\"! The mission of the Enterprise Resource Planning (ERP) Development team is to automate our business operations - you will contribute to our cross-functional system design and development with a clear vision of quality and scalability.", 
                            StartDate = new DateTime(2019, 11, 25), DueDate = new DateTime(2019, 12, 30) },
                new Job() { JobTitle = "Web Designer", 
                            JobDescription = "Do you have a creative eye for design? Do you research what makes people do the things they do? Are you obsessive about designing a product with great user experience? KiwiCo is looking for a creative and strategic designer who is passionate about design and obsessive about designing online products with great user experience. The Web Designer at KiwiCo is responsible for designing the user interface of the KiwiCo website by balancing the needs of our users, our design aesthetic as well as the objectives of the business.", 
                            StartDate = new DateTime(2019, 12, 16), DueDate = new DateTime(2020, 1, 16) },
                new Job() { JobTitle = "Computer Vision Engineer", 
                            JobDescription = "Airbnb’s Emerging Technology R&D team explores new technologies to spark innovation within the company, focusing on a 12–24 month time horizon. With a focus on computer vision, spatial computing, and augmented reality, we are focused on leveraging new technologies and Airbnb’s focus on high-quality imagery to create new internal and external tools and products.", 
                            StartDate = new DateTime(2019, 12, 1), DueDate = new DateTime(2020, 2, 1) }
            };
            foreach (var job in _jobs)
            {
                context.Jobs.Add(job);
            }
            context.SaveChanges();

            context.Jobs.Find(1).Employer = context.Employers.Find(6);
            context.Jobs.Find(2).Employer = context.Employers.Find(5);
            context.Jobs.Find(3).Employer = context.Employers.Find(5);
            context.Jobs.Find(4).Employer = context.Employers.Find(8);
            context.Jobs.Find(5).Employer = context.Employers.Find(7);

            context.Employees.Find(1).AppliedJobs.Add(context.Jobs.Find(1));
            context.Employees.Find(2).AppliedJobs.Add(context.Jobs.Find(1));
            context.Employees.Find(2).AppliedJobs.Add(context.Jobs.Find(2));
            context.Employees.Find(2).AppliedJobs.Add(context.Jobs.Find(3));
            context.Employees.Find(3).AppliedJobs.Add(context.Jobs.Find(1));
            context.Employees.Find(3).AppliedJobs.Add(context.Jobs.Find(2));
            context.Employees.Find(4).AppliedJobs.Add(context.Jobs.Find(1));

            base.Seed(context);
        }
    }
}