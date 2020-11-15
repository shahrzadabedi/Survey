namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSurveyStatusToSurvey2 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Surveys", "Discriminator");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Surveys", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
