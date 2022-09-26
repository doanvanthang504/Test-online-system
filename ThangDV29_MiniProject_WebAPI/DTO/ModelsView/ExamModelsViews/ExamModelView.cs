using System;
using System.Linq;
using ThangDV29_MiniProject_WebAPI.Models;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class ExamModelView
    {
        public ExamModelView(Exam exam)
        {
            ID = exam.ID;
            NameExam = exam.NameExam;
            TimeExam = exam.TimeExam;
            TotalQuestion = exam.ExamQuestions.Count();
            DateExam = exam.DateExam;
        }
        public Guid ID { get; set; }

        public string NameExam { get; set; }

        public int? TimeExam { get; set; }

        public int TotalQuestion { get; set; }

        public DateTime? DateExam { get; set; }
    }
}
