using System;

namespace ThangDV29_MiniProject_WebAPI.Models.Table
{
    public class StudentExam
    {
        public int ID { get; set; }
        public Guid? StudentID { get; set; }
        public Guid? ExamID { get; set; }
        public bool? Status { get; set; }
        public double? Score { get; set; }
        public DateTime? DateExam { get; set; }
        public Account Students { get; set; }
        public Exam Exams { get; set; }
    }
}
