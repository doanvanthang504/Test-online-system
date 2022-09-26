using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Configuration;
using ThangDV29_MiniProject_WebAPI.Models.SeedData;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.SeedData;

namespace ThangDV29_MiniProject_WebAPI.ApplicationDBContext
{
    public class MyApplicationDBContext : DbContext, IApplicationDBContext
    {
        public MyApplicationDBContext(DbContextOptions<MyApplicationDBContext> options) : base(options) { }

        #region DB_Set
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<HistoryExam> HistoryExams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ExamQuestion> ExamQuestion { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        #endregion

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration table
            #region Fluent API
            modelBuilder.ApplyConfiguration(new ExamQuestionConfiguration());

            modelBuilder.ApplyConfiguration(new HistoryExamConfiguration());

            modelBuilder.ApplyConfiguration(new AnswerConfiguration());

            modelBuilder.ApplyConfiguration(new StudentExamCofiguration());

            modelBuilder.ApplyConfiguration(new AccountConfiguration());

            modelBuilder.ApplyConfiguration(new QuestionAnswerConfiguration());
            #endregion

            #region HasData
            //Seed Data
            modelBuilder.Entity<Account>().HasData(AccountSeedData.Accounts);

            modelBuilder.Entity<Question>().HasData(QuestionSeedData.Questions);

            modelBuilder.Entity<Answer>().HasData(AnswerSeedData.Answers);

            modelBuilder.Entity<Exam>().HasData(ExamSeedData.Exams);

            modelBuilder.Entity<ExamQuestion>().HasData(QuestionExamSeedData.QuestionExams);

            modelBuilder.Entity<StudentExam>().HasData(StudentExamSeedData.StudentExams);

            modelBuilder.Entity<QuestionAnswer>().HasData(QuestionAnswerSeedData.QuestionAnswers);
            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
