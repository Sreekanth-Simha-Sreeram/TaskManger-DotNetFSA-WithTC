using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities.Entity;
using TaskManager.BusinessLayer.ServicesImplimentation;
using TaskManager.DataLayer.NHibernate;
using NSubstitute;

namespace TaskManagerCoreTest.FunctionalTest
{
    class FunctionalTest
    {

        private readonly ProjectManagerServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        UserServices user_services;
        Tasks tasks;


        public FunctionalTest()
        {
            _service = new ProjectManagerServices(_session);
        }


        [SetUp]
        public void init()
        {
           // projectManager = new ProjectManagerServices();
            user_services = new UserServices();
        }

        []
        public void AddTaskTest()
        {
            //Arrange
          tasks = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action
            var IsAdded = _service.AddTask(tasks);

            //Action
            Assert.AreEqual(true, IsAdded);
        }


        [Test]
        public void ViewTasksTestForManager()
        {
            List<Tasks> listTask = new List<Tasks>();
            User users = new User();

            //Action
            var listOfTaskForManager = _service.ViewTask();

            //Assert
            Assert.AreEqual(listTask, listOfTaskForManager);
        }


        [Test]
        public void Test_For_UpdatingTaskTest()
        {
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action
            var updatedtask = _service.UpdateTask(task.TaskId);
            var gotUpadtedTask = _service.GetTaskById(task.TaskId);

            //Assert
            Assert.AreEqual(gotUpadtedTask, updatedtask);
        }


        public void EndTaskTest()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action

            var IsEnded = _service.EndTask(task);

            //Action
            Assert.AreEqual(true, IsEnded);
        }

        
        [Test]
        public void TestSearchTask()
        {
            //Arrange 
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };
            User user = new User();

            //Action
            var Searchedtask=user_services.SearchTask(task,user);
            var searched = user_services.getTaskById(task.TaskId);
           
            //Assert
            Assert.AreEqual(searched, Searchedtask);
        }

        [Test]
        public void ViewTasksForUserTest()
        {
            List<Tasks> listTask = new List<Tasks>();
            listTask.Add(tasks);
            User users = new User();

            //Action
           
             var listOfTaskForUser = user_services.ViewTask(users);

            //Assert
            Assert.AreEqual(listTask, listOfTaskForUser);
        }

    }
}

    
