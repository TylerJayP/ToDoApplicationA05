using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class NewTaskPage : Form
    {
        public NewTaskPage()
        {
            InitializeComponent();
            this.Text = "New Task";
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void LowButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void MediumButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HighButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddNewTask_Click(object sender, EventArgs e)
        {
            string name = taskName.Text;
            DateTime dt = dateTimePicker1.Value;
            Priority p;
            if (LowButton.Checked == true)
                p = Priority.LOW;
            else if (MediumButton.Checked == true)
                p = Priority.MEDIUM;
            else
                p = Priority.HIGH;
            string info = TaskInfo.Text;

            if (dt.Date == DateTime.Today)
            {
                Program.home.AddCurrentTask(new Task(name, dt, p, info));
                this.Close();
            }
            else if (dt.Date > DateTime.Today)
            {
                Program.home.AddUpcomingTask(new Task(name, dt, p, info));
                this.Close();
            }
            else
            {
                addNewTask.Enabled = false;
            }
        }

        public void TaskInfo_TextChanged(object sender, EventArgs e)
        {
            /*string taskInfo;
            taskInfo = richTextBox1.Text;*/
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void NewTaskPage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(LowButton);
            groupBox1.Controls.Add(MediumButton);
            groupBox1.Controls.Add(HighButton);
            Controls.Add(groupBox1);
        }
    }
}