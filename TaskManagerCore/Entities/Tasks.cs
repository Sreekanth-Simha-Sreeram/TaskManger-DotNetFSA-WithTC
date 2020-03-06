using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerCore.Entities
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public int ParentTaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Range(1, 30)]
        public int Priority { get; set; }

    }
}
