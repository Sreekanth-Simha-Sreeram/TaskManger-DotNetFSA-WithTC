using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.BusinessLayer.ServicesImplimentation;
using TaskManager.DataLayer.NHibernate;
using TaskManager.Entities.Entity;
using TaskManagerCoreTest.Execption;

namespace TaskManagerCoreTest.ExceptionTest
{
    [TestFixture]
    class ExceptionTest
    {

        private readonly ProjectManagerServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        UserServices user_services;
        Tasks tasks;


        public ExceptionTest()
        {
            _service = new ProjectManagerServices(_session);
        }




        [Test]
        public void ExceptionTestForPriority()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 31
            };

            Assert.GreaterOrEqual(1, task.Priority);

        }


        [Test]
        public void ExceptionTestForTaskNotFound()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 31
            };

            User user = new User() { Id = 11, Name = "John", email = "john@gmail.com", Password = "john123" };
            user_services.SearchTask(task, user);

            //Assert
            var ex = Assert.Throws<TaskNotFoundExceptions>(() => user_services.SearchTask(task, user));
            Assert.AreEqual("Task Not Found in Tasks List", ex.Messages);
            Assert.That(user_services.SearchTask(task, user), Throws.TypeOf<TaskManagerExceptions>());
        }

    }
        
    }

