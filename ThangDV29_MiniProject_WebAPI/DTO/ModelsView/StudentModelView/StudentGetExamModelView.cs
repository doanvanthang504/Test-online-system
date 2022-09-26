using System;
using System.Collections.Generic;

namespace ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView
{
    public class StudentGetExamModelView
    {
        public Guid ID { get; set; }
        public string NameExam { get; set; }
        public DateTime? DateExam { get; set; }
        public int? TimeExam { get; set; }

        public virtual ICollection<ExamWithQuestionsModelView> ExamHaveManyQuestion { get; set; }
    }
}
