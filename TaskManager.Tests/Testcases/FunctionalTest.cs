using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities.Entity;

using TaskManager.DataLayer.NHibernate;
using NSubstitute;
using Xunit;
using TaskManager.BusinessLayer.Services;

namespace TaskManager.Tests.Testcases
{
   public class FunctionalTest
    {

        private readonly ProjectManagerServices _ManagerService;
        private readonly UserServices _UserService;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        
        public FunctionalTest()
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

        User user = new User()
        {
            Id = 1,
            Name = "john",
            email = "jphn@gmail.com",
            Password = "123987"
        };


        [Fact]
        public void TestFor_AddTask()
        {
            //Arrange
            //Action
            var IsAdded = _ManagerService.AddTask(tasks);

            //Action
            Assert.True(IsAdded);
        }


        [Fact]
        public void TestFor_ViewTasksTestForManager()
        {
            //Arrange
            List<Tasks> listTask = new List<Tasks>();
            listTask.Add(tasks);

            //Action
            var listOfTaskForManager = _ManagerService.ViewTask();

            //Assert
            Assert.Equal(listTask, listOfTaskForManager);
        }

        [Fact]
        public void TestFor_UpdatingTaskByManager()
        {

            //Action
            var updatedtask = _ManagerService.UpdateTask(tasks.TaskId);
            var gotUpadtedTask = _ManagerService.GetTaskById(tasks.TaskId);

            //Assert
            Assert.Equal(gotUpadtedTask, updatedtask);
        }

        [Fact]
        public void TestFor_EndTaskByManager()
        {
            //Action
            var IsEnded = _ManagerService.EndTask(tasks);

            //Action
            Assert.True(IsEnded);
        }




        [Fact]
        public void TestFor_SearchTaskByUser()
        {
            //Arrange 
            //Action
            var Searchedtask = _UserService.SearchTask(tasks, user);
            var searched = _UserService.getTaskById(tasks.TaskId);

            //Assert
            Assert.Equal(searched, Searchedtask);
        }

        [Fact]
        public void TestFor_ViewTaskByUser()
        {
            //Arrange
            List<Tasks> listTask = new List<Tasks>();
            listTask.Add(tasks);

            //Action
            var listOfTaskForUser = _UserService.ViewTask(user);

            //Assert
            Assert.Equal(listTask, listOfTaskForUser);
        }

        [Fact]
        public void TestFor_EndTaskByUser()
        {
            //Arrange
         

            //Action
            var EndTask = _UserService.EndTask(user.Id);

            //Assert
            Assert.True(EndTask);
        }

        [Fact]
        public void TestFor_makeParentTask()
        {
            //Arrange
            //Action
            var IsAdded = _ManagerService.MakeParent(tasks.ParentTaskId,tasks.TaskId);

            //Action
            Assert.True(IsAdded);
        }


    }
}

    
