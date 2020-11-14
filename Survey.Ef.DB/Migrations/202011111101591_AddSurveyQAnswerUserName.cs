namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Net.NetworkInformation;

    public partial class AddSurveyQAnswerUserName : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Questions",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            QId = c.Int(nullable: false),
            //            QDesc = c.String(),
            //            Survey_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Surveys", t => t.Survey_Id)
            //    .Index(t => t.Survey_Id);

            //CreateTable(
            //    "dbo.Surveys",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Duration = c.Int(nullable: false),
            //            CreatorUserName = c.String(),
            //            State = c.Int(nullable: false),
            //            CreateDateTime = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);

            //CreateTable(
            //    "dbo.SurveyAnswerHistories",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserName = c.String(),
            //            AnswerStatus = c.Int(nullable: false),
            //            AnswerDateTime = c.DateTime(nullable: false),
            //            Survey_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Surveys", t => t.Survey_Id)
            //    .Index(t => t.Survey_Id);

            //CreateTable(
            //    "dbo.SurveyQAnswers",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Answer = c.Short(nullable: false),
            //            LastSuveyAnswerStatus = c.Int(nullable: false),
            //            UserAnswerDateTime = c.DateTime(nullable: false),
            //            UserName = c.String(),
            //            Question_Id = c.Int(),
            //            Survey_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Questions", t => t.Question_Id)
            //    .ForeignKey("dbo.Surveys", t => t.Survey_Id)
            //    .Index(t => t.Question_Id)
            //    .Index(t => t.Survey_Id);
            AddColumn("dbo.SurveyQAnswers", "UserName", c=>c.String());
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.SurveyQAnswers", "Survey_Id", "dbo.Surveys");
            //DropForeignKey("dbo.SurveyQAnswers", "Question_Id", "dbo.Questions");
            //DropForeignKey("dbo.SurveyAnswerHistories", "Survey_Id", "dbo.Surveys");
            //DropForeignKey("dbo.Questions", "Survey_Id", "dbo.Surveys");
            //DropIndex("dbo.SurveyQAnswers", new[] { "Survey_Id" });
            //DropIndex("dbo.SurveyQAnswers", new[] { "Question_Id" });
            //DropIndex("dbo.SurveyAnswerHistories", new[] { "Survey_Id" });
            //DropIndex("dbo.Questions", new[] { "Survey_Id" });
            //DropTable("dbo.SurveyQAnswers");
            //DropTable("dbo.SurveyAnswerHistories");
            //DropTable("dbo.Surveys");
            //DropTable("dbo.Questions");

            DropColumn("dbo.SurveyQAnswers", "UserName");
        }
    }
}
