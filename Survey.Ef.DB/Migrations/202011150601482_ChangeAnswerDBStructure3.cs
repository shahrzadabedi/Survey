namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnswerDBStructure3 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Surveys", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Surveys", "Discriminator");
        }
    }
}
