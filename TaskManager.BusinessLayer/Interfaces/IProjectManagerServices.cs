using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Entities.Entity;

namespace TaskManager.BusinessLayer.Interfaces
{
   public interface IProjectManagerServices
    {
        bool AddTask(Tasks Task);
        List<Tasks> ViewTask();
        Tasks UpdateTask(int TaskId);
        bool MakeParent(int ParentTaskId,int ChildTaskId);
        bool EndTask(Tasks task);
    }
}
