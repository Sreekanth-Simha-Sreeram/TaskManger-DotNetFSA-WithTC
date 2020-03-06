using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Tests.Exceptions
{
   public class ParentChildExceptions:Exception
    {
        public string Messages = "One child cannot have two parents ";

        public ParentChildExceptions(string message)
        {
            Messages = message;
        }
    }
}