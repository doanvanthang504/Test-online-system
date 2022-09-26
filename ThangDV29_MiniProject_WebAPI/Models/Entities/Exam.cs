using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public Guid ID { get; set; }

        public string NameExam { get; set; }

        public int? TimeExam { get; set; }

        public DateTime? DateExam { get; set; }

        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }
        public virtual ICollection<HistoryExam> HistoryExams { get; set; }
        public virtual ICollection<StudentExam> StudentExams { get; set; }
        public Exam()
        {
            StudentExams = new List<StudentExam>();
            ExamQuestions = new List<ExamQuestion>();
            HistoryExams = new List<HistoryExam>();
        }
    }
}
