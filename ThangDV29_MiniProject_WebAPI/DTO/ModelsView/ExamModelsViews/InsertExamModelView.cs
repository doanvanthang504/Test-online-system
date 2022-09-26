using System;
using System.Collections.Generic;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class InsertExamModelView
    {
        public string NameExam { get; set; }

        public int? TimeExam { get; set; }

        public DateTime? DateExam { get; set; }

        public List<Guid> QuestionID { get; set; }
    }
}
