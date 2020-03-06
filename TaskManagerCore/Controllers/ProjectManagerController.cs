using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagerCore.Entities;

namespace TaskManager.Web.Controllers
{
    public class ProjectManagerController : Controller
    {

        public bool AddTask(Tasks task)
        {
            //code here to add new task
            return true;
        }

        public bool EndTask(Tasks task)
        {
            //code here to end task
            return true;

        }

        public IActionResult UpdateTask(int TaskId)
        {
            // Code here to update task by id
            return View();
        }


        public IActionResult ViewTask()
        {
            //code here to view task
            return View();
        }


        public IActionResult GetTaskById(int TaskId)
        {
            //code here to get task by id
            return View();
        }


        public bool MakeParent(int ParentTaskId, int ChildTaskId)
        {
            //code here to make one task as the parent to another task
            return true;
        }
        
    }
}