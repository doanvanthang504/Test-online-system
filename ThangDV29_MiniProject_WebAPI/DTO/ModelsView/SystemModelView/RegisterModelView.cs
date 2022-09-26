using System.ComponentModel.DataAnnotations;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class RegisterModelView
    {
        public string FullName { get; set; }

        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string BirthDay { get; set; }
    }
}
