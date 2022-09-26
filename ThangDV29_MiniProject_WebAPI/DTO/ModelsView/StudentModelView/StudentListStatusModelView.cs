using System;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.ModelsView.StudentGetExamModelView
{
    public class StudentListStatusModelView
    {
        public Guid? StudentID { get; set; }
        public Guid? ExamID { get; set; }
        public bool? Status { get; set; }
        public StudentListStatusModelView(StudentExam studentExam)
        {
            ExamID = studentExam.ExamID;
            StudentID = studentExam.StudentID;
            Status = studentExam.Status;
        }
       
    }
}
