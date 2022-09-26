using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Controllers;
using ThangDV29_MiniProject_WebAPI.Extention;
using ThangDV29_MiniProject_WebAPI.Models;
using ThangDV29_MiniProject_WebAPI.Models.Enum;
using ThangDV29_MiniProject_WebAPI.ModelsView;
using ThangDV29_MiniProject_WebAPI.ModelsView.SystemModelView;
using ThangDV29_MiniProject_WebAPI.Services.InterfaceServices;
using Xunit;

namespace ThangDV29_MiniProject_WebAPI_Test
{
    public class AdminAccountManagerController_Test
    {
        private readonly Mock<IAccountManagerService> _mockAccountManagerService;
        private readonly Mock<ILoggerManager> _mockLoggerManager;
        public readonly AdminAccountManagerController _adminAccountManagerController;
        public AdminAccountManagerController_Test()
        {
            _mockAccountManagerService = new Mock<IAccountManagerService>();
            _mockLoggerManager = new Mock<ILoggerManager>();
            _adminAccountManagerController = new AdminAccountManagerController(_mockAccountManagerService.Object, _mockLoggerManager.Object);
        }
        [Fact]
        public async Task FindAllAsyncTest()
        {
            Account ac = new Account()
            {
                Email = "doanvanthang@gmail.com",
                FullName = "doanvanthang",
                Username = "Thang",
                Role = Roles.Student,
                BirthDay = DateTime.Parse("21/02/1999"),
                DateCreate = DateTime.Parse("21/02/2022"),
                IsBLock = true,
                IsAuthentication = false,
            };
            IEnumerable<ListAccountModelView> mockList = new List<ListAccountModelView>()
            {
                new ListAccountModelView(ac)
                {
                    Email = ac.Email,
                    FullName = ac.FullName,
                    Username = ac.Username,
                    Role = ac.Role,
                    BirthDay =ac.BirthDay,
                    DateCreate =ac.DateCreate,
                    IsBLock = ac.IsBLock,
                    IsAuthentication = ac.IsAuthentication
                }
            };

            _mockAccountManagerService.Setup(e => e.FindAllAsync())
                              .Returns(Task.FromResult(mockList));

            var result = await _adminAccountManagerController.FindAllAsync();
            Assert.Equal((IEnumerable<ListAccountModelView>)Task.FromResult(mockList), ((IEnumerable<ListAccountModelView>)result));
        }
    }
}
