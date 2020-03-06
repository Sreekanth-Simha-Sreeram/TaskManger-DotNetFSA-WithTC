using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Entities.Entity;

namespace TaskManager.BusinessLayer.Interfaces
{
   public interface IUserservices
    {
        Tasks SearchTask(Tasks task, User user);
        Tasks EditTask(int Id);
        List<Tasks> ViewTask(User users);
        bool EndTask(int Id);
        Tasks getTaskById(int Id);
    }
}
