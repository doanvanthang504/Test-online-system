using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThangDV29_MiniProject_WebAPI.Models.Enum;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(100)]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public Roles Role { get; set; }

        public DateTime? BirthDay { get; set; }

        public DateTime? DateCreate { get; set; }
        public bool IsAuthentication { get; set; }
        public bool IsBLock { get; set; }

        public ICollection<HistoryExam> HistoryExams { get; set; }
        public ICollection<StudentExam> StudentExams { get; set; }
        public ICollection<ExamQuestion> ExamQuestions { get; set; }

        public Account()
        {
            StudentExams = new List<StudentExam>();
            HistoryExams = new List<HistoryExam>();
            ExamQuestions = new List<ExamQuestion>();
            IsBLock = false;
            IsAuthentication = false;
        }


    }
}
