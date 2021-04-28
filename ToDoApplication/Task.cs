using System;
using System.Collections.Generic;

namespace ToDoApplication
{
    /// <summary>
    /// Class with get and set properties for Name, DateTime, Priority, and Info.
    /// </summary>
    public class Task : IEquatable<Task>, IComparable<Task>
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public Priority p { get; set; }
        public string info { get; set; }

        /// <summary>
        /// Constructor for Name, DateTime, Priority, Info.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="dt"></param>
        /// <param name="p"></param>
        /// <param name="info"></param>
        public Task(string Name, DateTime dt, Priority p, string info)
        {
            this.Name = Name;
            this.dt = dt.Date;
            this.p = p;
            this.info = info;
        }

        /// <summary>
        /// Creating a ToString method on how we want to print out our Task stuff.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name: {0}\nDate: {1}\nInfo: {2}\n", this.Name, this.dt.Date.ToShortDateString(), this.info);
        }

        public int CompareTo(Task y)
        {
            //Date Time
            if (this.dt.CompareTo(y.dt) != 0)
                return this.dt.CompareTo(y.dt);
            //Priority
            if (this.p > y.p)
                return 1;
            if (this.p < y.p)
                return -1;
            //Name
            if (this.Name.CompareTo(y.Name) != 0)
                return this.Name.CompareTo(y.Name);
            //Info
            return (this.info.CompareTo(y.info));
        }

        public bool Equals(Task other)
        {
            return this.Name == other.Name && this.p == other.p && this.dt == other.dt && this.info == other.info;
        }
    }
}
