using System;

namespace ToDoApplication
{
  
    public class Task : IEquatable<Task>, IComparable<Task>
    {
        public string Name { get; set; }
        public DateTime dt { get; set; }
        public Priority p { get; set; }
        public string info { get; set; }

        /// <summary>
        /// Constructor that intakes information for Name, DateTime, Priority, Info.
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
        /// Prints current task in the following format
        /// Name: {Task name}
        /// Date: {Task date}
        /// Info: {Task info}
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name: {0}\nDate: {1}\nInfo: {2}\n", this.Name, this.dt.Date.ToShortDateString(), this.info);
        }

        /// <summary>
        /// Implementation of CompareTo to allow sorting of collections of Task objects.
        /// Sorts first by DateTime, then Priority, then Name, then Info.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Implementation of Equals method to determine whether two tasks are identical or not.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Task other)
        {
            return this.Name == other.Name && this.p == other.p && this.dt == other.dt && this.info == other.info;
        }
    }
}
