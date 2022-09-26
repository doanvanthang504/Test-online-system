using System;
using System.Collections.Generic;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models
{

    public class Answer
    {
        public Guid ID { get; set; }

        public string ImageAnswer { get; set; }

        public string DescriptionAnswer { get; set; }

        public virtual ICollection<HistoryExam> HistoryExams { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public Answer()
        {
            HistoryExams = new List<HistoryExam>();
            QuestionAnswers = new List<QuestionAnswer>();
        }
    }
}
