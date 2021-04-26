using System;

namespace ToDoApplication
{
    /// <summary>
    /// Class with get and set properties for Name, DateTime, Priority, and Info.
    /// </summary>
    public class Task : IComparable<Task>
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
        /// <summary>
        /// Comparing each enum to each other to sort it in our listbox on the Homepage.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Task other)
        {
            return this.p.CompareTo(other.p);
            //throw new NotImplementedException();
        }
    }
}
