using System;

namespace ToDoApplication
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public Priority p { get; set; }
        public string info { get; set; }

        public Task(string Name, DateTime dt, Priority p, string info)
        {
            this.Name = Name;
            this.dt = dt.Date;
            this.p = p;
            this.info = info;
        }


        public override string ToString()
        {
            return String.Format("Name: {0}\nDate: {1}\nInfo: {2}\n", this.Name, this.dt, this.info);
        }

    }
}
