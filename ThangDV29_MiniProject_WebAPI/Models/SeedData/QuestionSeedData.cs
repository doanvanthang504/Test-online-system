using System;
using System.Collections.Generic;

namespace ThangDV29_MiniProject_WebAPI.Models.SeedData
{
    public class QuestionSeedData
    {
        public static List<Question> Questions = new List<Question>
        {
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                NameQuestion = "Con heo co may chan",
                ImageQuestion = "www.image1 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                NameQuestion = "Con cho co may chan",
                ImageQuestion = "www.image2 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"),
                NameQuestion = "Con ga co may chan",
                ImageQuestion = "www.image3 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b4d"),
                NameQuestion = "Con gan co may chan",
                ImageQuestion = "www.imag4 "
            },
            new Question()
            {
                ID =  new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b5d"),
                NameQuestion = "Con chim co may chan",
                ImageQuestion = "www.image5 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96facc9b6d"),
                NameQuestion = "Con chim mau gi",
                ImageQuestion = "www.image6 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b6d"),
                NameQuestion = "Con gi khong biet boi",
                ImageQuestion = "www.image6 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b7d"),
                NameQuestion = "Ai dep chai nhat",
                ImageQuestion = "www.image6 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b8d"),
                NameQuestion = "Bao cham bao nhieu diem",
                ImageQuestion = "www.image6 "
            },
            new Question()
            {
                ID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b9d"),
                NameQuestion = "Code tao co sach khong",
                ImageQuestion = "www.image6 "
            }
        };
    }
}
