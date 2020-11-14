namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SurveyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false ;
        }

        protected override void Seed(SurveyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                //context.UserAnswers.AddOrUpdate(
                //  p => p.UserName,
                //  new UserAnswer { UserName = "sh.abedi" }
                ////  new SurveyQAnswer { FullName = "Brice Lambson" },
                // // new SurveyQAnswer { FullName = "Rowan Miller" }
                //);
            
        }
    }
}
