using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.BusinessLayer.ServicesImplimentation;
using TaskManager.DataLayer.NHibernate;
using TaskManager.Entities.Entity;

namespace TaskManagerCoreTest.Testcases
{
    class BoundaryTest
    {

        private readonly ProjectManagerServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        UserServices user_services;
        Tasks tasks;


        public BoundaryTest()
        {
            _service = new ProjectManagerServices(_session);
        }

    }
}
