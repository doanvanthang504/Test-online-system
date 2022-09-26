using System;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    public class ExamQuestion
    {
        public Guid ID { get; set; }

        public Guid QuestionID { get; set; }

        public Guid ExamID { get; set; }

        public Guid TeacherID { get; set; }

        public virtual Question Questions { get; set; }
        public virtual Exam Exams { get; set; }
        public virtual Account Teacher { get; set; }
    }
}
