namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnswerDBStructure1 : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "dbo.Answers", name: "Survey_Id", newName: "Question_Id");
            //RenameIndex(table: "dbo.Answers", name: "IX_Survey_Id", newName: "IX_Question_Id");
        }
        
        public override void Down()
        {
            //RenameIndex(table: "dbo.Answers", name: "IX_Question_Id", newName: "IX_Survey_Id");
            //RenameColumn(table: "dbo.Answers", name: "Question_Id", newName: "Survey_Id");
        }
    }
}
