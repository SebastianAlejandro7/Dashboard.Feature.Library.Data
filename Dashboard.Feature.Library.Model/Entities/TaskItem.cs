using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Library.Model.Entities
{
    public class TaskItem : EntityBase
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
