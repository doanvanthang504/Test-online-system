using System;
using System.Collections.Generic;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models.SeedData
{
    public class QuestionAnswerSeedData
    {
        public static List<QuestionAnswer> QuestionAnswers = new List<QuestionAnswer>
        {
            new QuestionAnswer()
            {
                ID=1,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                AnswerID = new Guid("ce6882a5-7e2d-4ec0-85c8-c9fc96998da7"),
                ResultAnswer = true
            },
            new QuestionAnswer()
            {
                ID=2,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                AnswerID = new Guid("ec0983cf-316c-4a00-9ea0-9aa5e8a1b44f"),
                ResultAnswer = true
            },
            new QuestionAnswer()
            {
                ID=3,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                AnswerID = new Guid("6687b5b9-a407-4f34-88af-ef10b58fffc9"),
                ResultAnswer = false
            },
            new QuestionAnswer()
            {
                ID= 4,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                AnswerID = new Guid("8f5be11b-caf1-4a63-9121-0b8b3668fb5d"),
                ResultAnswer = true
            },
            new QuestionAnswer()
            {
                ID = 5,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b1d"),
                AnswerID =  new Guid("2d9fa7e8-420f-45b9-99e4-031fa241d1b6"),
                ResultAnswer = false
            },
            new QuestionAnswer()
            {
                ID = 6,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                AnswerID = new Guid("35c5e7a7-3176-42fc-8d1b-347809614b90"),
                ResultAnswer = true
            },
            new QuestionAnswer()
            {
                ID = 7,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b3d"),
                AnswerID = new Guid("2f084f72-0692-43ee-8b0f-15644fcef973"),
                ResultAnswer = true
            },
            new QuestionAnswer()
            {
                ID = 8,
                QuestionID = new Guid("b42cea50-b2e1-4467-91a0-7e96fccc9b2d"),
                AnswerID = new Guid("f19beebe-16a5-492e-9197-2ed7ee51effc"),
                ResultAnswer = false
            }
        };
    }
}
