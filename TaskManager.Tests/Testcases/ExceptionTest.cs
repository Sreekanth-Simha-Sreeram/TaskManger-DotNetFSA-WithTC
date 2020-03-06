using NSubstitute;

using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.BusinessLayer.Services;
using TaskManager.DataLayer.NHibernate;
using TaskManager.Entities.Entity;
using TaskManager.Tests.Exceptions;
using TaskManagerCoreTest.Execption;
using Xunit;

namespace TaskManager.Tests.Testcases
{
   
 public  class ExceptionTest
    {
        private readonly ProjectManagerServices _ManagerService;
        private readonly UserServices _UserService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public ExceptionTest()
        {
            _ManagerService = new ProjectManagerServices(_session);
            _UserService = new UserServices();
        }

        Tasks tasks = new Tasks()
        {
            TaskId = 18,
            ParentTaskId = 2,
            ParentTaskName="abc",
            TaskName = " ",
            StartDate = new DateTime(2020, 02, 18),
            EndDate = new DateTime(2020, 02, 20),
            Priority = 31
        };
        User user = new User()
        {
            Id = 11,
            Name = "John",
            email = "john@gmail.com",
            Password = "john123"
        };


        [Fact]
        public void ExceptionTestForTaskNotFound()
        {
            //Arrange
            //Assert
            var ex = Assert.Throws<TaskNotFoundExceptions>(() => _UserService.SearchTask(tasks, user));
            Assert.Equal("Task Not Found in Tasks List", ex.Messages);
        }

        [Fact]
        public void ExceptionTestForMandatoryFieldsInTask()
        {
            //Arrange
            Tasks tasks = new Tasks()
            {
                TaskId = 18,
                ParentTaskId =0,
                ParentTaskName="",
                TaskName = "abc ",
                StartDate =DateTime.MinValue ,
                EndDate = DateTime.MinValue,
                Priority = 31
            };
            //Assert

            var ex = Assert.Throws<RequiredFieldsExceptions>(() => _ManagerService.AddTask(tasks));
            Assert.Equal("ParenttaskNmae cannot be empty", ex.Messages);
        }
        [Fact]
        public void ExceptionTestForStartDateEndDate()
        {
            //Arrange
            Tasks tasks = new Tasks()
            {
                TaskId = 18,
                ParentTaskId = 1,
                ParentTaskName = "abc",
                TaskName = "aabc ",
                StartDate = DateTime.Now,
                EndDate = DateTime.MinValue,
                Priority = 31
            };
            //Assert

            var ex = Assert.Throws<StartDateEndDateExceptions>(() => _ManagerService.AddTask(tasks));
            Assert.Equal("Enddate should not be greater than startdate", ex.Messages);
        }
        [Fact]
        public void ExceptionTestForChildTask()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 18,
                ParentTaskId = 1,
                ParentTaskName = "abc",
                
            };
            //Assert

            var ex = Assert.Throws<ParentChildExceptions>(() => _ManagerService.MakeParent(task.ParentTaskId,tasks.TaskId));
            Assert.Equal("One child cannot have two parents", ex.Messages);
        }
    }

}

