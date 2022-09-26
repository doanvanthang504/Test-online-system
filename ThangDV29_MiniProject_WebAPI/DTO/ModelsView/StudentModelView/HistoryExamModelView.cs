using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView
{
    public class HistoryExamModelView
    {
        public Guid? ExamID { get; set; }
        public string NameExam { get; set; }
        public string DateExam { get; set; }
    }
}
