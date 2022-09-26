using System;

namespace ThangDV29_MiniProject_WebAPI
{
    public class SignUpResult
    {
        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public Object Token { get; set; }
    }
}
