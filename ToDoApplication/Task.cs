using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Task
    {
        string Name { get; set; }
        DateTime dt { get; set; }
        Priority p { get; set; }
        string info { get; set; }

        public Task(string Name, DateTime dt, Priority p, string info)
        {
            this.Name = Name;
            this.dt = dt;
            this.p = p;
            this.info = info;
        }
    }
}
