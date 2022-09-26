using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    public interface IApplicationDBContext
    {
        DbSet<Account> Accounts { get; set; }

        DbSet<Answer> Answers { get; set; }

        DbSet<Exam> Exams { get; set; }

        DbSet<HistoryExam> HistoryExams { get; set; }

        DbSet<Question> Questions { get; set; }

        DbSet<ExamQuestion> ExamQuestion { get; set; }

        DbSet<StudentExam> StudentExams { get; set; }

        DbSet<QuestionAnswer> QuestionAnswers {get;set;}


        Task<int> SaveChangesAsync();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
