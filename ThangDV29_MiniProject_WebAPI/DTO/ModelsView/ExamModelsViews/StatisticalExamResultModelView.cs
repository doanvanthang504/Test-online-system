namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class StatisticalExamResultModelView
    {
        public int SuccessStudentCount { get; set; }
        public int FailureStudentCount { get; set; }
        public int WeakStudentCount { get; set; }
        public int BadStudentCount { get; set; }
        public int GoodStudentCount { get; set; }
        public int VeryGoodStudentCount { get; set; }
        public int ExcellentStudentCount { get; set; }

        public StatisticalExamResultModelView(int Successfull_Student_Count, int Fail_Student_Count,
                                              int Weak_Student_Count, int Bad_Student_Count, int Good_Student_Count,
                                              int VeryGood_Student_Count, int Excellent_Student_Count)
        {
            SuccessStudentCount = Successfull_Student_Count;
            FailureStudentCount = Fail_Student_Count;
            WeakStudentCount = Weak_Student_Count;
            BadStudentCount = Bad_Student_Count;
            GoodStudentCount = Good_Student_Count;
            VeryGoodStudentCount = VeryGood_Student_Count;
            ExcellentStudentCount = Excellent_Student_Count;
        }
    }
}
