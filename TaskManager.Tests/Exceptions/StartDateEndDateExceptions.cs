using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Tests.Exceptions
{
    public class StartDateEndDateExceptions : Exception
    {

        public string Messages = "Enddate should not be greater than startdate";

        public StartDateEndDateExceptions(string message)
        {
            Messages = message;
        }


    }
}