using System.Data.Entity.Migrations;

namespace IvyPan.LotusD.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LotusD.EntityFramework.LotusDDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LotusD";
        }

        protected override void Seed(LotusD.EntityFramework.LotusDDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
