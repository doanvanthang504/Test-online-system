using System;
using System.Collections.Generic;

namespace ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView
{
    public class ExamWithQuestionsModelView
    {
        public Guid QuestionID { get; set; }
        public string NameQuestion { get; set; }
        public string ImageQuestion { get; set; }

        public virtual ICollection<QuestionAndAnswerModelView> QuestionAndAnswers { get; set; }
    }
}
