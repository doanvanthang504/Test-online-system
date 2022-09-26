using AutoMapper;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.AnswerModelView;
using ThangDV29_MiniProject_WebAPI.ModelsViews;

namespace ThangDV29_MiniProject_WebAPI.Extention
{
    public class AutoMapperExtension : Profile
    {
        public AutoMapperExtension()
        {
            CreateMap<AccountModelsView, Account>().ReverseMap();
            CreateMap<LoginModelview, Account>().ReverseMap();
            CreateMap<RegisterModelView, Account>().ForMember(e => e.BirthDay, options => options.Ignore())
                                                   .ReverseMap();

            CreateMap<InsertExamModelView, Exam>().ReverseMap();
            CreateMap<AnswerModelView, ExamQuestion>().ReverseMap();
            CreateMap<EditQuestionsModelView, Question>().ReverseMap();
            CreateMap<AnswerModelView, Answer>().ReverseMap();
            CreateMap<InsertAnswerModelView, Answer>().ReverseMap();
        }
    }
}
