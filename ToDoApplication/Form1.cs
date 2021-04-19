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
    public partial class Form1 : Form
    {
        List<string> completedTasks = new List<string>();
        List<string> currentTasks = new List<string>();
        List<string> upcomingTasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "ToDo Application";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            PopulateList(upcomingTasks, "UpcomingTasks.txt");
            PopulateList(currentTasks, "CurrentTasks.txt");
            PopulateList(completedTasks, "CompletedTasks.txt");
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
            var newTaskForm = new Form2();
            newTaskForm.Show();
        }

        //User selects Upcoming/Previous/Current
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;


           //Index Sheet: 0 = Current || 1 = Previous || 2 = Upcoming
           //ListBox2 is the control for this one (Current Tasks)
            if(selectedIndex == 0)
            {
                listBox1.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                listBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Items.AddRange(currentTasks.ToArray());
            }
            //ListBox3 is the control of this one (Previous Tasks)
            if(selectedIndex == 1)
            {
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox4.Visible = false;
                listBox3.Visible = true;
                listBox3.Items.Clear();
                listBox3.Items.AddRange(completedTasks.ToArray());
            }
            //ListBox4 is the control of this one (Upcoming Tasks)
            if(selectedIndex == 2)
            {
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = true;
                listBox4.Items.Clear();
                listBox4.Items.AddRange(upcomingTasks.ToArray());
            }
        }

        //Edit Button
        public void button3_Click(object sender, EventArgs e)
        {
            var updateTaskForm = new Form3();
            updateTaskForm.Show();
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
        private void button4_Click(object sender, EventArgs e)
        {
            //Removing selected item(s) from Current Tasks
            ListBox.SelectedObjectCollection currentItems = new ListBox.SelectedObjectCollection(listBox2);
            currentItems = listBox2.SelectedItems;
            
            if (listBox2.SelectedIndex != -1)
            {
                for (int i = currentItems.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.Remove(currentItems[i]);                   
                }
            }

            //Removing selected item(s) from Previous Tasks
            ListBox.SelectedObjectCollection previousItems = new ListBox.SelectedObjectCollection(listBox3);
            previousItems = listBox3.SelectedItems;
            if (listBox3.SelectedIndex != -1)
            {
                for (int h = previousItems.Count - 1; h >= 0; h--)
                {
                    listBox3.Items.Remove(previousItems[h]);
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
            
            if(listBox2.SelectedItem == null)
            {
                richTextBox2.Text = "Removed!";
            }
            else
            {
                richTextBox2.Text = listBox2.SelectedItem.ToString();
            }
            
        }

        //Previous Tasks ListBox
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null)
            {
                richTextBox2.Text = "Removed!";
            }
            else
            {
                richTextBox2.Text = listBox3.SelectedItem.ToString();
            }
        }
        //Upcoming Tasks ListBox
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem == null)
            {
                richTextBox2.Text = "Removed!";
            }
            else
            {
                richTextBox2.Text = listBox4.SelectedItem.ToString();
            }
        }

        private void PopulateList(List<string> taskList, string folder)
        {
            string line;

            using (StreamReader reader = new StreamReader(folder))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    taskList.Add(line);
                }
                reader.Close();
            }
        }
    }
}
