using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class QuestionManagerService : IQuestionManagerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionManagerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            var findID = await FindByIdAsync(id);
            _unitOfWork.QuestionRepository.Delete(findID);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result == false)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<GetQuestionModelView>> FindAllAsync()
        {
            var QuestionList = await _unitOfWork.QuestionRepository.FindAllAsync();
            var result = QuestionList.Select(e => new GetQuestionModelView(e));
            return result;
        }

        public async Task<Question> FindByIdAsync(Guid id)
        {
            var findID = await _unitOfWork.QuestionRepository.FindByIdAsync(id);
            return findID;
        }

        public async Task<CheckNameQuestion> Insert(EditQuestionsModelView questionsModelView)
        {
            var findName = await _unitOfWork.QuestionRepository
                                            .Find(e => e.NameQuestion == questionsModelView.NameQuestion);
            if(findName.Count() > 0)
            {
                return new CheckNameQuestion
                {
                    IsExistss = false,
                    MessageQuestion = "Name Question Exists"
                };
            }
            var question = _mapper.Map<Question>(questionsModelView);
            _unitOfWork.QuestionRepository.Insert(question);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckNameQuestion
                {
                    IsExistss = true,
                    MessageQuestion = "Insert Question Successful !!"
                };
            }
            else
            {
                return new CheckNameQuestion
                {
                    IsExistss = false,
                    MessageQuestion = "SaveChange Failed !!"
                };
            }
        }

        public async Task<CheckNameQuestion> Update(EditQuestionsModelView questionsModelView, Guid id)
        {
            var findName = await _unitOfWork.QuestionRepository
                                             .Find(e => e.NameQuestion == questionsModelView.NameQuestion);
            if (findName.Count() > 0)
            {
                return new CheckNameQuestion
                {
                    IsExistss = false,
                    MessageQuestion = "Name Question Exists"
                };
            }
            var findID = await FindByIdAsync(id);

            findID.NameQuestion = questionsModelView.NameQuestion;
            findID.ImageQuestion = questionsModelView.ImageQuestion;

            _unitOfWork.QuestionRepository.Update(findID);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckNameQuestion
                {
                    IsExistss = true,
                    MessageQuestion = "Update Question Successful !!"
                };
            }
            else
            {
                return new CheckNameQuestion
                {
                    IsExistss = false,
                    MessageQuestion = "SaveChange Failed !!"
                };
            }
        }
    }
}
