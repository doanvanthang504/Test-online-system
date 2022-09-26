using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string NameQuestion { get; set; }

        public string ImageQuestion { get; set; }

        public ICollection<ExamQuestion> QuestionExams { get; set; }
        public ICollection<HistoryExam> HistoryExams { get; set; }
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public Question()
        {
            QuestionExams = new List<ExamQuestion>();
            HistoryExams = new List<HistoryExam>();
            QuestionAnswers = new List<QuestionAnswer>();
        }
    }
}
