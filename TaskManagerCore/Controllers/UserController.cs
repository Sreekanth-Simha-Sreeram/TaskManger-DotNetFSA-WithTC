using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagerCore.Entities;

namespace TaskManager.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult EditTask(int Id)
        {
            // code here to edit task by id
            return View();
        }

        public bool EndTask(int Id)
        {
            //code here to ens task
            return true;
        }

        public IActionResult SearchTask(Tasks task, User user)
        {
            //code here to search task
            return View();

        }

        public IActionResult ViewTask(User users)
        {
            //code here to view task
            return View();

        }

        public IActionResult getTaskById(int taskId)
        {
            //code here to get task by id
            return View();

        }
     
    }
}