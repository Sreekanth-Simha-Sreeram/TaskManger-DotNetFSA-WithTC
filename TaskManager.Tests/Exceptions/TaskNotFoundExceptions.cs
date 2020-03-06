using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagerCoreTest.Execption
{
    class TaskNotFoundExceptions : Exception
    {
        public string Messages = "Task Not Found in Tasks List";


      
        public TaskNotFoundExceptions(string message)
        {
            Messages = message;
        }
    }
    
}
