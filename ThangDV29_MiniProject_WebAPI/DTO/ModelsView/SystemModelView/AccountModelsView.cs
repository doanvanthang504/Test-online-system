using System;
using System.ComponentModel.DataAnnotations;
using ThangDV29_MiniProject_WebAPI.Models.Enum;

namespace ThangDV29_MiniProject_WebAPI.ModelsView
{
    public class AccountModelsView
    {
        public AccountModelsView()
        {
            IsBLock = false;
            IsAuthentication = false;
        }

        [Required]

        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Range(0, 2)]
        public Roles Role { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime DateCreate { get; set; }

        public bool IsBLock { get; set; }

        public bool IsAuthentication { get; set; }

    }
}
