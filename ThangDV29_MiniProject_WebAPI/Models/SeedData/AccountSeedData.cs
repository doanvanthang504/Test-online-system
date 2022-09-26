using System;
using System.Collections.Generic;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Enum;

namespace ThangDV29_MiniProject_WebAPI.SeedData
{
    public class AccountSeedData
    {
        public static List<Account> Accounts = new List<Account>
        {
            new Account
            {
                ID= new Guid("A68393FF-15FA-4136-85E2-71CDC505D8E8"),
                Email="doanvanthang504@gmail.com",
                FullName="DOAN VAN THANG",
                Username="doanvanthang504",
                PasswordHash= BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Admin,
                BirthDay = new DateTime(1999, 2, 21),
                DateCreate= DateTime.Parse( DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = true
            },
            new Account
            {
                ID= new Guid("2C273E26-C2DD-4956-8E13-7C25C2A1158B"),
                Email="lethihoa99@gmail.com",
                FullName="LE THI HOA",
                Username="lethihoa99",
                PasswordHash= BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Teacher,
                BirthDay = new DateTime(1998, 7, 11),
                DateCreate= DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = true
            },
            new Account
            {
                ID = new Guid("23e22ae9-c14a-4e5d-8bf0-e4734143ed41"),
                Email="taolagiaovien@gmail.com",
                FullName="tao la giao vien",
                Username="giaovien",
                PasswordHash= BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Teacher,
                BirthDay = new DateTime(1988, 7, 11),
                DateCreate= DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = true
            },
            new Account
            {
                ID = new Guid("e280d537-732c-465a-ab22-74d4cbb696c2"),
                Email="taolagiaovien22@gmail.com",
                FullName="tao la giao vien 22",
                Username="giaovien2",
                PasswordHash= BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Teacher,
                BirthDay = new DateTime(1988, 7, 11),
                DateCreate= DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = true
            },
            new Account
            {
                ID = new Guid("9C7B60B6-44B6-4A6F-9C4B-A0ECE4672421"),
                Email = "nguyenvananh123@gmail.com",
                FullName = "NGUYEN VAN ANH",
                Username = "nguyenvananh123",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Student,
                BirthDay = new DateTime(2000, 1, 19),
                DateCreate = DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = false
            },
            new Account
            {
                ID = new Guid("A277D8AE-DF9E-4259-909B-A7C790B9389A"),
                Email = "duonganhhong98@gmail.com",
                FullName = "DUONG ANH HONG",
                Username = "duonganhhong98",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Student,
                BirthDay = new DateTime(2000, 8, 30),
                DateCreate = DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = false
            },
            new Account
            {
                ID = new Guid("A177D8AE-DF9E-4259-909B-A7C790B9389A"),
                Email = "lekhanhhoa@gmail.com",
                FullName = "Le Khanh Hoa",
                Username = "lekhanhhoa",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Student,
                BirthDay = new DateTime(2000, 8, 30),
                DateCreate = DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = false
            },
            new Account
            {
                ID = new Guid("A377D8AE-DF9E-4259-909B-A7C790B9389A"),
                Email = "bao123@gmail.com",
                FullName = "Pham Tran Huy Bao",
                Username = "phamtranhuybao123",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Student,
                BirthDay = new DateTime(2000, 8, 30),
                DateCreate = DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = false
            },
            new Account
            {
                ID = new Guid("A477D8AE-DF9E-4259-909B-A7C790B9389A"),
                Email = "duyduyduy@gmail.com",
                FullName = "Van Duy",
                Username = "duyduyduy1",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                Role = Roles.Student,
                BirthDay = new DateTime(2000, 8, 30),
                DateCreate = DateTime.Parse(DateTime.UtcNow.ToString()),
                IsBLock = false,
                IsAuthentication = false
            },
        };

    }
}
