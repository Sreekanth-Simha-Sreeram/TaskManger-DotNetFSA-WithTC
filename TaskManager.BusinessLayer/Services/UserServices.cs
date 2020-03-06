using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.BusinessLayer.Interfaces;
using TaskManager.Entities.Entity;


namespace TaskManager.BusinessLayer.Services
{
    public class UserServices: IUserservices
    {
        public Tasks EditTask(int Id)
        {
            Tasks task = new Tasks();
            return task;
        }

        public bool EndTask(int Id)
        {
            return true;
        }

        public Tasks SearchTask(Tasks task, User user)
        {

            Tasks tasks = new Tasks();

            return tasks;

        }

        public List<Tasks> ViewTask(User users)
        {

            List<Tasks> tasklist = new List<Tasks>();
            return tasklist;

        }

      public Tasks  getTaskById(int taskId)
        {
            Tasks tasks = new Tasks();

            return tasks;

        }  


    }
}
