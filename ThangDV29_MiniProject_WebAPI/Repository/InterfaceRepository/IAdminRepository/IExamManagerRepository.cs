using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepo;

namespace ThangDV29_MiniProject_WebAPI.Repository.InterfaceRepository
{
    public interface IExamManagerRepository : IGenericRepository<Exam>
    {
        Task<IEnumerable<ExamModelView>> GetAllExamQuestion();
        Task<Exam> FindUserByNameExam(string nameExam);
       
    }
}
