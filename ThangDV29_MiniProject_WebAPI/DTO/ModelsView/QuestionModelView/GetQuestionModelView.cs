using System;
using ThangDV29_MiniProject_WebAPI.Models;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class GetQuestionModelView
    {
        public GetQuestionModelView(Question question)
        {
            ID = question.ID;
            NameQuestion = question.NameQuestion;
            ImageQuestion = question.ImageQuestion;
        }
        public Guid ID { get; set; }

        public string NameQuestion { get; set; }

        public string ImageQuestion { get; set; }
    }
}
