using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Entities.Entity
{
    public class Tasks
    {
        public virtual int TaskId { get; set; }
    
        public virtual int ParentTaskId { get; set; }
        [Required]
        public virtual string ParentTaskName { get; set; }

        public virtual string TaskName { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }

        [Range(1, 30)]
        public virtual int Priority { get; set; }

    }
}
