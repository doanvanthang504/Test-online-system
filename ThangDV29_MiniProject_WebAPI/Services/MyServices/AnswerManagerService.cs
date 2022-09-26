using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention.CheckExtention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Table;
using ThangDV29_MiniProject_WebAPI.ModelsView.AnswerModelView;
using ThangDV29_MiniProject_WebAPI.ModelsViews;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using ThangDV29_MiniProject_WebAPI.UnitOfWork;

namespace ThangDV29_MiniProject_WebAPI.Services.MyServices
{
    public class AnswerManagerService : IAnswerManagerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnswerManagerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            var findID = await FindByIdAsync(id);
            _unitOfWork.AnswerRepository.Delete(findID);

            var result = await _unitOfWork.SaveChangeAsync();
            if (result == false)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<IEnumerable<Answer>> FindAllAsync()
        {
            var AnswerList = await _unitOfWork.AnswerRepository.FindAllAsync();
            return AnswerList;
        }

        public async Task<Answer> FindByIdAsync(Guid id)
        {
            var findID = await _unitOfWork.AnswerRepository.FindByIdAsync(id);
            return findID;
        }

        public async Task<CheckAnswer> Insert(InsertAnswerModelView answerModelView)
        {
            var answer = _mapper.Map<Answer>(answerModelView);

            _unitOfWork.AnswerRepository.Insert(answer);
            var questionAnswer = new QuestionAnswer()
            {
                QuestionID = answerModelView.QuestionID,
                AnswerID = answer.ID,
                ResultAnswer = answerModelView.ResultAnswer
            };
            _unitOfWork.QuestionAnswerReoisitory.Insert(questionAnswer);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckAnswer
                {
                    Success = true,
                    Message = "Insert Question Successful !!"
                };
            }
            else
            {
                return new CheckAnswer
                {
                    Success = false,
                    Message = "SaveChange Failed !!"
                };
            }
        }

        public async Task<CheckAnswer> Update(AnswerModelView answerModelView, Guid id)
        {
            var findId = await FindByIdAsync(id);

            findId.DescriptionAnswer = answerModelView.Description;
            findId.ImageAnswer = answerModelView.ImageAnswer;

            _unitOfWork.AnswerRepository.Update(findId);
            var result = await _unitOfWork.SaveChangeAsync();
            if (result)
            {
                return new CheckAnswer
                {
                    Success = true,
                    Message = "Update Question Successful !!"
                };
            }
            else
            {
                return new CheckAnswer
                {
                    Success = false,
                    Message = "SaveChange Failed !!"
                };
            }
        }
    }
}
