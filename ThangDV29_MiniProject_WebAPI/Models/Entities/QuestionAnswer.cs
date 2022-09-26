using System;

namespace ThangDV29_MiniProject_WebAPI.Models.Table
{
    public class QuestionAnswer
    {
        public int ID { get; set; }
        public Guid QuestionID { get; set; }
        public Guid AnswerID { get; set; }
        public bool ResultAnswer { get; set; }

        public virtual Question Questions { get; set; }

        public virtual Answer Answers { get; set; }
    }
}
