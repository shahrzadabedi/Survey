using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Ef.DB
{    
    public class SurveyContext : DbContext
    {
        public SurveyContext() : base("name=SurveyConnection")
        {

        }
        // public SurveyContext(string s) : base(s) { }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Configurations.Add(new QuestionMapper());
        //}

    }

    //public class QuestionMapper : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Question>
    //{
    //    public QuestionMapper()
    //    {
    //        this.Property(a => a.QDesc).HasColumnName("Description").HasMaxLength(200);
    //    }
    //}
}
