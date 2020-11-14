namespace Survey.Ef.DB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAnswerDBStructure : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SurveyAnswerHistories", "Survey_Id", "dbo.Surveys");
            DropForeignKey("dbo.SurveyQAnswers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.SurveyQAnswers", "Survey_Id", "dbo.Surveys");
            DropIndex("dbo.SurveyAnswerHistories", new[] { "Survey_Id" });
            DropIndex("dbo.SurveyQAnswers", new[] { "Question_Id" });
            DropIndex("dbo.SurveyQAnswers", new[] { "Survey_Id" });
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Short(nullable: false),
                        Question_Id = c.Int(),
                        UserAnswer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .ForeignKey("dbo.UserAnswers", t => t.UserAnswer_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.UserAnswer_Id);
            
            CreateTable(
                "dbo.UserAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnswerStatus = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        CompleteDateTime = c.DateTime(nullable: false),
                        UserLastAnswerDateTime = c.DateTime(nullable: false),
                        UserName = c.String(),
                        Survey_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Surveys", t => t.Survey_Id)
                .Index(t => t.Survey_Id);
            
            DropTable("dbo.SurveyAnswerHistories");
            DropTable("dbo.SurveyQAnswers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SurveyQAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.Short(nullable: false),
                        LastSuveyAnswerStatus = c.Int(nullable: false),
                        UserAnswerDateTime = c.DateTime(nullable: false),
                        UserName = c.String(),
                        Question_Id = c.Int(),
                        Survey_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SurveyAnswerHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        AnswerStatus = c.Int(nullable: false),
                        AnswerDateTime = c.DateTime(nullable: false),
                        Survey_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Answers", "UserAnswer_Id", "dbo.UserAnswers");
            DropForeignKey("dbo.UserAnswers", "Survey_Id", "dbo.Surveys");
            DropForeignKey("dbo.Answers", "Survey_Id", "dbo.Questions");
            DropIndex("dbo.UserAnswers", new[] { "Survey_Id" });
            DropIndex("dbo.Answers", new[] { "UserAnswer_Id" });
            DropIndex("dbo.Answers", new[] { "Survey_Id" });
            DropTable("dbo.UserAnswers");
            DropTable("dbo.Answers");
            CreateIndex("dbo.SurveyQAnswers", "Survey_Id");
            CreateIndex("dbo.SurveyQAnswers", "Question_Id");
            CreateIndex("dbo.SurveyAnswerHistories", "Survey_Id");
            AddForeignKey("dbo.SurveyQAnswers", "Survey_Id", "dbo.Surveys", "Id");
            AddForeignKey("dbo.SurveyQAnswers", "Question_Id", "dbo.Questions", "Id");
            AddForeignKey("dbo.SurveyAnswerHistories", "Survey_Id", "dbo.Surveys", "Id");
        }
    }
}
