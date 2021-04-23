using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApplication
{
   
    public partial class Homepage : Form
    {
        IList<Task> previousTasks { get; set; }
        IList<Task> currentTasks { get; set; }
        IList<Task> upcomingTasks { get; set; }
        

        public Homepage()
        {
            this.previousTasks = new List<Task>();
            this.currentTasks = new List<Task>();
            this.upcomingTasks = new List<Task>();

            InitializeComponent();
            this.Text = "ToDo Application";
        }

        public void AddUpcomingTask(Task task)
        {
            this.upcomingTasks.Add(task);
        }
        
        public void AddCurrentTask(Task task)
        {
            this.currentTasks.Add(task);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
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


            //Index Sheet: 0 = Current || 1 = Previous || 2 = Upcoming
            //ListBox2 is the control for this one (Current Tasks)
            if (selectedIndex == 0)
            {
                listBox4.Visible = true;
                listBox4.Items.Clear();
                List<string> taskNames = new List<string>();
                foreach (Task t in currentTasks)
                {
                    taskNames.Add(t.Name);
                }
                listBox4.Items.AddRange(taskNames.ToArray());
            }
            //ListBox3 is the control of this one (Previous Tasks)
            if (selectedIndex == 1)
            {
                listBox4.Visible = true;
                listBox4.Items.Clear();
                listBox4.Items.AddRange(previousTasks.ToArray());
            }
            //ListBox4 is the control of this one (Upcoming Tasks)
            if (selectedIndex == 2)
            {
                listBox4.Visible = true;
                listBox4.Items.Clear();
                List<string> taskNames = new List<string>();
                foreach (Task t in upcomingTasks)
                {
                    taskNames.Add(t.Name);
                }
                listBox4.Items.AddRange(taskNames.ToArray());

            }
        }

        //Edit Button
        public void button3_Click(object sender, EventArgs e)
        {
            /*var updateTaskForm = new Form3();
            updateTaskForm.Show();*/
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Main ListBox That Will Get Changed
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        //Current Tasks ListBox
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox4.SelectedItem.ToString();
            if (listBox4.SelectedItem == null)
            {
                InfoBox.Text = "Removed!";
            }
            else
            {
                var cTask =
                   from c in currentTasks
                   where c.Name == selectedItem
                   select c;
                StringBuilder s = new StringBuilder();
                foreach (Task t in cTask)
                {
                    s.Append(t.ToString() + "\n");
                }
                Console.WriteLine(s.ToString());
                InfoBox.Text = s.ToString();
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

        //Upcoming Tasks ListBox
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox4.SelectedItem.ToString();
            if (listBox4.SelectedItem == null)
            {
                InfoBox.Text = "Removed!";
            }
            else
            {
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
    }
}
