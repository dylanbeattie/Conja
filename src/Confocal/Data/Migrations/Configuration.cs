using System.EnterpriseServices;
using System.Text;

namespace Confocal.Data.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Confocal.Data.ConfocalDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Data\Migrations";
        }

        private void MakeTalk(string title) {
            var bytes = Encoding.UTF8.GetBytes(title);
        }

        protected override void Seed(Confocal.Data.ConfocalDbContext context) {
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Talks.AddOrUpdate(t => t.TalkId,
                new Talk { TalkId = Guid.Parse("deadbeef-e3a9-4a45-bb18-55b96fb23a7c"), Title = "How I Learned to Stop Worrying and Love Audience Feedback" },
                new Talk { TalkId = Guid.Parse("deadbeef-5748-44eb-aafa-e12ce8cd9f00"), Title = "Adventures with Sharepoint" },
                new Talk { TalkId = Guid.Parse("deadbeef-5170-4468-aaaf-16efff5396a7"), Title = "Jam, Jerusalem and JavaScript" },
                new Talk { TalkId = Guid.Parse("deadbeef-78dc-4063-9b03-0721a4c670d8"), Title = "2^128 Things You Never Knew About GUIDs" },
                new Talk { TalkId = Guid.Parse("deadbeef-b675-432c-8e35-69b61c3db123"), Title = "Front-End Fun with SASS and Coffee" }
            );
        }
    }
}
