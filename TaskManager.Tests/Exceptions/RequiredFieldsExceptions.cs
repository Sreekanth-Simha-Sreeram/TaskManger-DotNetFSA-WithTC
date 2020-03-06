using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Tests.Exceptions
{
   public class RequiredFieldsExceptions:Exception
    {
        public string Messages = "ParenttaskNmae cannot be empty ";
                   
        public RequiredFieldsExceptions(string message)
        {
            Messages = message;
        }
    }

}