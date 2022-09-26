using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository;

namespace ThangDV29_MiniProject_WebAPI.Repository.MyRepository
{
    public class ExamManagerRepository : GenericRepository<Exam>, IExamManagerRepository
    {
        public ExamManagerRepository(IApplicationDBContext dbContext) : base(dbContext)
        { }

        public async Task<Exam> FindUserByNameExam(string nameExam)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.NameExam == nameExam);
        }

        public async Task<IEnumerable<ExamModelView>> GetAllExamQuestion()
        {
            var examList = await _dbSet.Include(p => p.ExamQuestions).ToListAsync();

            var result = examList.Select(e => new ExamModelView(e));
            return result;
            
        }
    }
}
