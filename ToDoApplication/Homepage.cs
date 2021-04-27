using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDoApplication
{ 
    /// <summary>
    /// Creating our main Lists for each task to be saved and used for the get and set properties.
    /// </summary>
    public partial class Homepage : Form
    {
        public static IList<Task> previousTasks { get; set; }
        public static IList<Task> currentTasks { get; set; }
        public static IList<Task> upcomingTasks { get; set; }

        /// <summary>
        /// Constructs new instance of homepage
        /// </summary>
        public Homepage()
        {
            previousTasks = new List<Task>();
            currentTasks = new List<Task>();
            upcomingTasks = new List<Task>();
            InitializeComponent();
            this.Text = "ToDo Application";
        }

        /// <summary>
        /// Helper method for updating upcoming tasks
        /// </summary>
        /// <param name="task"></param>
        public void AddUpcomingTask(Task task)
        {
            upcomingTasks.Add(task);
        }

        /// <summary>
        /// Helper method for updating current tasks
        /// </summary>
        /// <param name="task"></param>
        public void AddCurrentTask(Task task)
        {
            currentTasks.Add(task);
        }

        /// <summary>
        /// Loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// User presses "Completed" on a selected task and that task will be removed from upcomingtasks or currenttasks and moved into previoustasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            //Takes task from either upcoming task or current task and deletes from those lists
            //Then adds it to previous 
            switch (comboBox1.SelectedIndex)
            {
                //Current
                case 0:
                    if (listBox4.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else if (listBox4.SelectedItem != null && currentTasks.Any())
                    {
                        string selectedItem = listBox4.SelectedItem.ToString();
                        int selectedIndex = listBox4.SelectedIndex;
                        var cTask =
                            from c in currentTasks
                            where c.Name == selectedItem
                            select c;
                        foreach (Task tk in cTask)
                        {
                            if (currentTasks.Any())
                            {
                                previousTasks.Add(tk);
                                currentTasks.Remove(tk);
                            }
                            break;
                        }
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in currentTasks)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                    }
                    else
                    {
                        InfoBox.Clear();
                    }
                    break;
                //Previous
                case 1:
                    break;
                //Upcoming
                case 2:
                    if (listBox4.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else if (listBox4.SelectedItem != null && upcomingTasks.Any())
                    {
                        string selectedItem = listBox4.SelectedItem.ToString();
                        int selectedIndex = listBox4.SelectedIndex;
                        var uTask =
                            from u in upcomingTasks
                            where u.Name == selectedItem.Substring(0, u.Name.Length)
                            select u;
                        foreach (Task tk in uTask)
                        {

                            if (upcomingTasks.Any())
                            {
                                previousTasks.Add(tk);
                                upcomingTasks.Remove(tk);
                            }
                            break;
                        }
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in upcomingTasks)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                    }
                    else
                    {
                        InfoBox.Clear();
                    }
                    break;
            }
        }

        /// <summary>
        /// Opens NewTaskPage Form for user to create a new task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTaskPage();
            newTaskForm.Show();
        }

        /// <summary>
        /// Sees what index on the combobox is selected to determine which listbox we are viewing.
        /// Adding the specific text files based on comobox.
        /// Populating the listboxes with our textfile and sorting it based on date and then priority.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            //Current Tasks
            if (selectedIndex == 0)
            {
                //Allow complete task button
                CompleteTask.Enabled = true;
                listBox4.Items.Clear();
                currentTasks.OrderBy(xx => xx.dt).ThenBy(x => x.p).ToList();
                List<string> names = new List();
                foreach(Task t in currentTasks)
                {
                    names.Add(t.Name);
                }
                listBox4.Items.AddRange(names.ToArray());
            }

            //Previous Tasks
            if (selectedIndex == 1)
            {
                //Disallow complete task button
                CompleteTask.Enabled = false;

                listBox4.Items.Clear();
                previousTasks.OrderBy(y => y.p).ToList();
                List<string> names = new List();
                foreach (Task t in previousTasks)
                {
                    names.Add(t.Name);
                }
                listBox4.Items.AddRange(names.ToArray());

            }

            //Upcoming Tasks
            if (selectedIndex == 2)
            {
                //Allow complete task button
                CompleteTask.Enabled = true;

                listBox4.Items.Clear();
                upcomingTasks.OrderBy(zz => zz.dt).ThenBy(z => z.p).ToList();
                List<string> names = new List();
                foreach (Task t in upcomingTasks)
                {
                    names.Add(t.Name + " : " + t.dt.ToShortDateString());
                }
                listBox4.Items.AddRange(names.ToArray());
            }
        }

        /// <summary>
        /// Opens EditTaskPage Form for user to edit a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button3_Click(object sender, EventArgs e)
        {
            var updateTaskForm = new EditTaskPage(comboBox1.SelectedIndex, listBox4.SelectedIndex);
            updateTaskForm.Show();
        }

        /// <summary>
        /// Removing the task using the remove button. Also, it's removing it from the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTask_Click(object sender, EventArgs e)
        {
            //Removing selected item(s) from Current Tasks
            ListBox.SelectedObjectCollection currentItems = new ListBox.SelectedObjectCollection(listBox4);
            currentItems = listBox4.SelectedItems;
            if (listBox4.SelectedIndex != -1 &&  comboBox1.SelectedIndex == 0)
            {
                currentTasks.RemoveAt(listBox4.SelectedIndex);
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);                         
            }
            //Removing selected item(s) from Previous Tasks
            ListBox.SelectedObjectCollection previousItems = new ListBox.SelectedObjectCollection(listBox4);
            previousItems = listBox4.SelectedItems;
            if (listBox4.SelectedIndex != -1 && comboBox1.SelectedIndex == 1)
            {
                previousTasks.RemoveAt(listBox4.SelectedIndex);
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);               
            }
            //Removing selected item(s) from Upcoming Tasks
            ListBox.SelectedObjectCollection upcomingItems = new ListBox.SelectedObjectCollection(listBox4);
            upcomingItems = listBox4.SelectedItems;
            if (listBox4.SelectedIndex != -1 && comboBox1.SelectedIndex == 2)
            {
                upcomingTasks.RemoveAt(listBox4.SelectedIndex);
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);              
            }
        }

        /// <summary>
        /// Prints the information from the specfic list into the richtextbox(infobox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                //Current
                case 0:
                    if (listBox4.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else
                    {                       
                        string selectedItem = listBox4.SelectedItem.ToString();
                        var cTask =
                            from c in currentTasks
                            where c.Name == selectedItem                         
                            select c;
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in cTask)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                    }
                    break;
                //Previous
                case 1:
                    if (listBox4.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else
                    {
                        string selectedItem = listBox4.SelectedItem.ToString();
                        var pTask =
                            from p in previousTasks
                            where p.Name == selectedItem
                            select p;
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in pTask)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                    }
                    break;
                //Upcoming
                case 2:
                    if (listBox4.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else
                    {
                        string selectedItem = listBox4.SelectedItem.ToString().Split(" : ")[0];
                        string selectedDate = listBox4.SelectedItem.ToString().Split(" : ")[1];

                        var uTask =
                        from u in upcomingTasks
                        where selectedItem == u.Name && selectedDate == u.dt.ToShortDateString()
                        select u;
                        StringBuilder s = new StringBuilder();
                        foreach (Task u in uTask)
                        {
                            s.Append(u.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
   
                    }
                    break;
            }
        }

        /// <summary>
        /// Creating a txt file that we will be populated with tasks that the user is inputting
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="folder"></param>
        private void PopulateList(IList<Task> taskList, string folder)
        {
            string line;
            try
            {
                using (StreamReader reader = new StreamReader(folder))
                {
                    reader.ReadToEnd();
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (folder == "UpcomingTasks.txt")
                            upcomingTasks.Add(readTask(folder, reader));
                        else if (folder == "CurrentTasks.txt")
                            currentTasks.Add(readTask(folder, reader));
                        else if (folder == "PreviousTasks.txt")
                            previousTasks.Add(readTask(folder, reader));
                    }
                };
            }
            catch (IOException)
            {
                Console.WriteLine("File hasn't been created yet...");
            }
        }

        /// <summary>
        /// Reads information from txt file and converts it into new Task Object
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        private ToDoApplication.Task readTask(string folder, StreamReader reader)
        {
            string name = reader.ReadLine();
            string dateTime = reader.ReadLine();
            var parsedDate = DateTime.Parse(dateTime);
            string priority = reader.ReadLine();
            Priority priorityEnum;
            switch (priority)
            {
                case "LOW":
                    priorityEnum = Priority.LOW;
                    break;
                case "MEDIUM":
                    priorityEnum = Priority.MEDIUM;
                    break;
                case "HIGH":
                    priorityEnum = Priority.HIGH;
                    break;
                default:
                    priorityEnum = Priority.LOW;
                    break;
            }
            string info = reader.ReadLine();
            return new ToDoApplication.Task(name, parsedDate, priorityEnum, info);
        }

        /// <summary>
        /// Creating a timer on the time to countiously count while the GUI is showing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Printing to each specific txt file.
        /// </summary>
        /// <param name="file"></param>
        public void printingToFile(string file)
        {
            try
            {
                using (StreamWriter sw = new(file, false))
                {
                    if (file == "CurrentTasks.txt")
                    {
                        foreach (Task t in currentTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                    if (file == "PreviousTasks.txt")
                    {
                        foreach (Task t in previousTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                    if (file == "UpcomingTasks.txt")
                    {
                        foreach (Task t in upcomingTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("StreamWriter is not functioning correctly.");
            }
           
        }

        /// <summary>
        /// Initializng each txt file to be printing out in a way that the GUI can convert to show the correct information
        /// in the correct places.
        /// </summary>
        /// <param name="file"></param>
        public void intializeList(String file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] aligning = line.Split(',');
                        Priority priorityEnum;
                        switch (aligning[2])
                        {
                            case "LOW":
                                priorityEnum = Priority.LOW;
                                break;
                            case "MEDIUM":
                                priorityEnum = Priority.MEDIUM;
                                break;
                            default:
                                priorityEnum = Priority.HIGH;
                                break;
                        }
                        switch (file)
                        {
                            case "UpcomingTasks.txt":
                                upcomingTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            case "CurrentTasks.txt":
                                currentTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            case "PreviousTasks.txt":
                                previousTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            default: break;
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("StreamReader is not functioning correctly");
            }
            
        }
    }
}
