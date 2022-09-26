using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;
using ThangDV29_MiniProject_WebAPI.Repository;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;
using ThangDV29_MiniProject_WebAPI.Repository.MyRepository;

namespace ThangDV29_MiniProject_WebAPI.UnitOfWork
{
    public class MyUnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDBContext _dbcontext;
        private readonly IOptionsMonitor<Appsetting> _appsetting;


        /*private readonly Appsetting _appsetting;*/

        public MyUnitOfWork(IApplicationDBContext dbContext, IOptionsMonitor<Appsetting> optionsMonitor)
        {
            _dbcontext = dbContext;
            _appsetting = optionsMonitor;
        }

        #region ElementRepository
        public IGenericRepository<Account> AccountRepository => new AccountManagerRepository(_dbcontext);

        public IGenericRepository<Exam> ExamRepository => new ExamManagerRepository(_dbcontext);

        public ILoginRepository LoginRepository => new LoginRepository(_dbcontext,_appsetting);

        public IResultManagerRepository ResultManagerRepository => new ResultManagerRepository(_dbcontext);

        public IGenericRepository<Question> QuestionRepository => new GenericRepository<Question>(_dbcontext);

        public IGenericRepository<Answer> AnswerRepository => new GenericRepository<Answer>(_dbcontext);

        public IGenericRepository<ExamQuestion> ExamQuestionRepository => new GenericRepository<ExamQuestion>(_dbcontext);

        public IStudentRepository StudentRepository => new StudentRepository(_dbcontext);

        public IGenericRepository<QuestionAnswer> QuestionAnswerReoisitory => new GenericRepository<QuestionAnswer>(_dbcontext);
        #endregion

        public async Task<bool> SaveChangeAsync()
        {
            var affectedRowCount = await _dbcontext.SaveChangesAsync();
            return affectedRowCount >= 1;
        }
    }
}
