using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.ModelsView;

namespace ThangDV29_MiniProject_WebAPI.DTO.ModelsView.StudentModelView
{
    public class HistoryExamStudentModelView
    {
        public string NameStudent { get; set; }
        public string Email { get; set; }
        public string BirthDay { get; set; }
        public IEnumerable<HistoryExamModelView> HistoryExams { get; set; }
    }
}
