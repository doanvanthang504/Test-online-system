namespace ThangDV29_MiniProject_WebAPI.DTO
{
    public class ScoreStudent
    {
        public double Score { get; set; }
        public bool IsSucceed { get; set; }

        public static ScoreStudent CreateSuccess(double score)
        {
            return new ScoreStudent
            {
                IsSucceed =true,
                Score = score
            };
        }

    }
}

