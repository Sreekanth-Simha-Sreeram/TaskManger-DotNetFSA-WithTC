using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.BusinessLayer.Services;
using TaskManager.DataLayer.NHibernate;
using TaskManager.Entities.Entity;
using Xunit;

namespace TaskManager.Tests.Testcases
{
   public class BoundaryTest
    {

        private readonly ProjectManagerServices _ManagerService;
        private readonly UserServices _UserService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            _ManagerService = new ProjectManagerServices(_session);
            _UserService = new UserServices();
        }
        Tasks tasks = new Tasks()
        {
            TaskId = 1,
            ParentTaskId = 2,
            TaskName = "MvcCrud",
            StartDate = new DateTime(2020, 02, 18),
            EndDate = new DateTime(2020, 02, 20),
            Priority = 20
        };

        [Fact]
        public void BoundaryTestFor_Priority()
        {
            //Arrange
            var minPriority = 1;
            var MaxPriority = 1;

            //Assert
            Assert.InRange(tasks.Priority, minPriority, MaxPriority);
        }

        [Fact]
        public void BoundaryTestFor_EditAfterEnd()
        {
            //Arrange
          
            User user = new User()
            {
                Id = 11,
                Name = "John",
                email = "john@gmail.com",
                Password = "john123"
            };

            var Endtask = _UserService.EndTask(user.Id);
            var EditTask = _UserService.EditTask(user.Id);

            //Assert
            Assert.Null(EditTask);
        }

        [Fact]
        public void BoundaryTestFor_ViewBeforeEnd()
        {
            //Arrange

            User user = new User()
            {
                Id = 11,
                Name = "John",
                email = "john@gmail.com",
                Password = "john123"
            };

            var task = _ManagerService.EndTask(tasks);
            var ViewTask = _ManagerService.ViewTask();

            //Assert
            Assert.NotEmpty(ViewTask);
        }




    }
}
