using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.UnitOfWork
{
    public interface IUnitOfWork
    {
        #region IRepository<T>
        IGenericRepository<Account> AccountRepository { get; }

        IGenericRepository<Exam> ExamRepository { get; }

        IGenericRepository<Question> QuestionRepository { get; }

        IGenericRepository<ExamQuestion> ExamQuestionRepository { get; }

        IGenericRepository<Answer> AnswerRepository { get; }
        IGenericRepository<QuestionAnswer> QuestionAnswerReoisitory { get; }

        IStudentRepository StudentRepository { get; }

        IResultManagerRepository ResultManagerRepository { get; }

        ILoginRepository LoginRepository { get; }
        #endregion

        Task<bool> SaveChangeAsync();
    }
}