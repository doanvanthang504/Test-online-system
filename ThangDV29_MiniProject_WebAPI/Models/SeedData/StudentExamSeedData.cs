using System;
using System.Collections.Generic;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models.SeedData
{
    public class StudentExamSeedData
    {
        public static List<StudentExam> StudentExams = new List<StudentExam>
        {
            new StudentExam()
            {
                ID = 1,
                StudentID = new Guid("9C7B60B6-44B6-4A6F-9C4B-A0ECE4672421"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 7.8,
                Status = true
            },
            new StudentExam()
            {
                ID = 2,
                StudentID = new Guid("A277D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 9.5,
                Status = true
            },
            new StudentExam()
            {
                ID = 3,
                StudentID = new Guid("A177D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 4 ,
                Status = false
            },
            new StudentExam()
            {
                ID = 4,
                StudentID = new Guid("A377D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 8.5,
                Status = true
            },
            new StudentExam()
            {
                ID = 5,
                StudentID = new Guid("A477D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 6,
                Status = true
            },
            new StudentExam()
            {
                ID = 6,
                StudentID = new Guid("A377D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 6.7,
                Status = true
            },
            new StudentExam()
            {
                ID = 7,
                StudentID = new Guid("A177D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 9.1,
                Status = true
            },
            new StudentExam()
            {
                ID = 8,
                StudentID = new Guid("A277D8AE-DF9E-4259-909B-A7C790B9389A"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                DateExam =  DateTime.UtcNow,
                Score = 8.7,
                Status = true
            }
        };
    }
}
