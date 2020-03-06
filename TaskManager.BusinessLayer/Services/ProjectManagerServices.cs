using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.BusinessLayer.Interfaces;
using TaskManager.DataLayer.NHibernate;
using TaskManager.Entities.Entity;


namespace TaskManager.BusinessLayer.Services
{
    public class ProjectManagerServices: IProjectManagerServices
    {

        private readonly IMapperSession _session;

        public ProjectManagerServices(IMapperSession session)
        {
            _session = session;
        }


        public bool AddTask(Tasks task)
        {
            return true;
        }

        public bool EndTask(Tasks task)
        {
            return true;

        }

        public Tasks UpdateTask(int TaskId)
        {
            Tasks task = new Tasks();
            return task;
        }


        public List<Tasks> ViewTask()
        {
            List<Tasks> tasklist = new List<Tasks>();
            return tasklist;
        }


        public Tasks GetTaskById(int TaskId)
        {
            Tasks task = new Tasks();
            return task;
        }

       
        public bool MakeParent(int ParentTaskId, int ChildTaskId)
        {
            return true;
        }

     
    }
}
