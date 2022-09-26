using System;
using System.Collections.Generic;

namespace ThangDV29_MiniProject_WebAPI.Models.SeedData
{
    public class QuestionExamSeedData
    {
        public static List<ExamQuestion> QuestionExams = new List<ExamQuestion>
        {
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID =  new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"),
                ExamID = new Guid("b12cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID =  new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"),
                ExamID = new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("B42CEA50-B2E1-4467-91A0-7E96FCCC9B4D"),
                ExamID= new Guid("b22cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
            new ExamQuestion()
            {
                ID = Guid.NewGuid(),
                QuestionID = new Guid("B42CEA50-B2E1-4467-91A0-7E96FCCC9B5D"),
                ExamID= new Guid("b32cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                TeacherID = new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
            },
        };
    }
}
