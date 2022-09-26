using System;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class StudentExamResultModelView
    {
        public string StudentName { get; set; }
        public string ExamName { get; set; }
        public DateTime? DateExam { get; set; }
        public bool? Status { get; set; }
        public double? Score { get; set; }
        public StudentExamResultModelView(StudentExam studentExam)
        {
            StudentName = studentExam.Students.FullName;
            ExamName = studentExam.Exams.NameExam;
            DateExam = studentExam.DateExam;
            Status = studentExam.Status;
            Score = studentExam.Score;
        }
    }
}
