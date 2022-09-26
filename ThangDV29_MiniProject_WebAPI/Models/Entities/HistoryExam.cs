using System;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    public class HistoryExam
    {
        public Guid ID { get; set; }

        public DateTime DateExam { get; set; }

        public Guid AccountID { get; set; }

        public Guid QuestionID { get; set; }

        public Guid AnswerID { get; set; }

        public Guid ExamID { get; set; }

        public Account Accounts { get; set; }
        public Question Questions { get; set; }
        public Answer Answers { get; set; }
        public Exam Exams { get; set; }
    }
}
