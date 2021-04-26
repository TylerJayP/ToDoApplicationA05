using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDoApplication
{ 

    public partial class Homepage : Form
    {
        private readonly int CURRENT = 0;
        private readonly int PREVIOUS = 1;
        private readonly int UPCOMING = 2;

        public static IList<Task> previousTasks { get; set; }
        public static IList<Task> currentTasks { get; set; }
        public static IList<Task> upcomingTasks { get; set; }

        public Homepage()
        {
            previousTasks = new List<Task>();
            currentTasks = new List<Task>();
            upcomingTasks = new List<Task>();

            InitializeComponent();
            this.Text = "ToDo Application";
        }

        public void AddUpcomingTask(Task task)
        {
            upcomingTasks.Add(task);
        }

        public void AddCurrentTask(Task task)
        {
            currentTasks.Add(task);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            PopulateList(upcomingTasks, "UpcomingTasks.txt");
            PopulateList(currentTasks, "CurrentTasks.txt");
            PopulateList(previousTasks, "CompletedTasks.txt");
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Complete Task
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
                    else if (listBox4.SelectedItem != null && currentTasks.Count >= 1)
                    {
                        string selectedItem = listBox4.SelectedItem.ToString();
                        int selectedIndex = listBox4.SelectedIndex;
                        var cTask =
                            from c in currentTasks
                            where c.Name == selectedItem
                            select c;
                        foreach (Task tk in cTask)
                        {
                            previousTasks.Add(tk);
                            currentTasks.Remove(tk);
                        }
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in currentTasks)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                        currentTasks.RemoveAt(selectedIndex);
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
                    else if (listBox4.SelectedItem != null && currentTasks.Count >= 1)
                    {
                        string selectedItem = listBox4.SelectedItem.ToString();
                        int selectedIndex = listBox4.SelectedIndex;
                        var uTask =
                            from u in upcomingTasks
                            where u.Name == selectedItem
                            select u;
                        foreach (Task tk in uTask)
                        {
                            previousTasks.Add(tk);
                            currentTasks.Remove(tk);
                        }
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in upcomingTasks)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                        previousTasks.RemoveAt(selectedIndex);
                    }
                    else
                    {
                        InfoBox.Clear();
                    }
                    break;
            }
        }

        //New Task
        public void button2_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTaskPage();
            newTaskForm.Show();
        }

        //User selects Upcoming/Previous/Current
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            //Current Tasks
            if (selectedIndex == 0)
            {
                //Allow complete task button
                CompleteTask.Enabled = true;

                listBox4.Visible = true;
                listBox4.Items.Clear();
                List<string> names = new List<string>();
                foreach (Task t in currentTasks)
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

                listBox4.Visible = true;
                listBox4.Items.Clear();
                List<string> names = new List<string>();
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

                listBox4.Visible = true;
                listBox4.Items.Clear();
                List<string> names = new List<string>();
                foreach (Task t in upcomingTasks)
                {
                    names.Add(t.Name);
                }
                listBox4.Items.AddRange(names.ToArray());

            }
        }

        //Edit Button
        //Changing the form parameters allows for passing of form controls along with their methods
        public void button3_Click(object sender, EventArgs e)
        {
            var updateTaskForm = new EditTaskPage(comboBox1.SelectedIndex, listBox4.SelectedIndex);
            updateTaskForm.Show();
        }

        public void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Remove Task
        private void RemoveTask_Click(object sender, EventArgs e)
        {
            //Removing selected item(s) from Current Tasks
            ListBox.SelectedObjectCollection currentItems = new ListBox.SelectedObjectCollection(listBox4);
            currentItems = listBox4.SelectedItems;

            if (listBox4.SelectedIndex != -1)
            {
                for (int i = currentItems.Count - 1; i >= 0; i--)
                {
                    listBox4.Items.Remove(currentItems[i]);
                }
            }

            //Removing selected item(s) from Previous Tasks
            ListBox.SelectedObjectCollection previousItems = new ListBox.SelectedObjectCollection(listBox4);
            previousItems = listBox4.SelectedItems;
            if (listBox4.SelectedIndex != -1)
            {
                for (int h = previousItems.Count - 1; h >= 0; h--)
                {
                    listBox4.Items.Remove(previousItems[h]);
                }
            }

            //Removing selected item(s) from Upcoming Tasks
            ListBox.SelectedObjectCollection upcomingItems = new ListBox.SelectedObjectCollection(listBox4);
            upcomingItems = listBox4.SelectedItems;
            if (listBox4.SelectedIndex != -1)
            {
                for (int j = upcomingItems.Count - 1; j >= 0; j--)
                {
                    listBox4.Items.Remove(upcomingItems[j]);
                }
            }
        }

        //Previous Tasks ListBox
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem == null)
            {
                InfoBox.Text = "Removed!";
            }
            else
            {
                InfoBox.Text = listBox4.SelectedItem.ToString();
            }
        }

        //Tasks ListBox
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
                        string selectedItem = listBox4.SelectedItem.ToString();
                        var uTask =
                            from c in upcomingTasks
                            where c.Name == selectedItem
                            select c;
                        StringBuilder s = new StringBuilder();
                        foreach (Task t in uTask)
                        {
                            s.Append(t.ToString() + "\n");
                        }
                        InfoBox.Text = s.ToString();
                    }
                    break;
            }
        }

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

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
