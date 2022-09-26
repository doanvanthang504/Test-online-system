using System.ComponentModel.DataAnnotations;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class LoginModelview
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
