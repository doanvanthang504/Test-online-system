using System;

namespace ThangDV29_MiniProject_WebAPI.ModelsView.AnswerModelView
{
    public class InsertAnswerModelView
    {
        public string ImageAnswer { get; set; }

        public string DescriptionAnswer { get; set; }

        public Guid QuestionID { get; set; }

        public bool ResultAnswer { get; set; }
    }
}
