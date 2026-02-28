namespace AdanaCafe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdanaCafe.Models.AdanaCafeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdanaCafe.Models.AdanaCafeContext context)
        {
            
        }
    }
}
