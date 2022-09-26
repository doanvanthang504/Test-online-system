using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThangDV29_MiniProject_WebAPI.Models.SeedData
{
    public class ExamSeedData
    {
        public static List<Exam> Exams = new List<Exam>
        {
            new Exam()
            {
                ID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                NameExam = "De de vai lon",
                TimeExam = 90,
                DateExam = DateTime.Now
            },
            new Exam()
            {
                ID = new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                NameExam = "code 180 phut",
                TimeExam = 180,
                DateExam = DateTime.Now
            },
            new Exam()
            {
                ID = new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                NameExam = "code thoi dung xam lol",
                TimeExam = 70,
                DateExam = DateTime.Now
            }
        };
    }
}
