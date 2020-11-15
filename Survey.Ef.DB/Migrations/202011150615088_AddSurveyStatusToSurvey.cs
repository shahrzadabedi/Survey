namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSurveyStatusToSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Surveys", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "State", c => c.Int(nullable: false));
            DropColumn("dbo.Surveys", "Status");
        }
    }
}
