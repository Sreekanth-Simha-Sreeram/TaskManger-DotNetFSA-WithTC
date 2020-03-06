using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaskManager.Entities.Entity;

namespace EMart.BusinessLayer
{
    public class ProductMap : ClassMap<Tasks>
    {
        public ProductMap()
        {

        Id(x => x.TaskId);

            Map(x => x.ParentTaskId );

            Map(x => x.TaskName);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.Priority);
            Table("tasks");

        }
    }


}
