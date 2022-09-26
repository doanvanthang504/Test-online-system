using System;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Enum;

namespace ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView
{
    public class ListAccountModelView
    {
        public ListAccountModelView(Account account)
        {
            Email = account.Email;
            FullName = account.FullName;
            Username = account.Username;
            Role = account.Role;
            BirthDay = account.BirthDay;
            DateCreate = account.DateCreate;
            IsBLock = account.IsBLock;
            IsAuthentication = account.IsAuthentication;
        }
        
        public string Email { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public Roles Role { get; set; }

        public DateTime? BirthDay { get; set; }

        public DateTime? DateCreate { get; set; }

        public bool IsBLock { get; set; }

        public bool IsAuthentication { get; set; }
    }
}
