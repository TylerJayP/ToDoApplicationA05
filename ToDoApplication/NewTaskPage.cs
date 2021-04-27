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
    /// <summary>
    /// Creates a New Task Form that the user will be able to create new tasks
    /// </summary>
    public partial class NewTaskPage : Form
    {
        public NewTaskPage()
        {
            InitializeComponent();
            this.Text = "New Task";
        }

        /// <summary>
        /// When "Add Task" is clicked, whatever the user has input and selected will be sent over to the listboxes that represent which
        /// date the user has input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddNewTask_Click(object sender, EventArgs e)
        {
            string name = taskName.Text;
            DateTime dt = dateTimePicker1.Value.Date;
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
                addNewTask.Enabled = true;
                Program.home.AddCurrentTask(new Task(name, dt, p, info));
                this.Close();
            }
            else if (dt.Date > DateTime.Today)
            {
                addNewTask.Enabled = true;
                Program.home.AddUpcomingTask(new Task(name, dt, p, info));
                this.Close();
            }
            else
            {
                MessageBox.Show("Can not add tasks to previous dates... silly");
                addNewTask.Enabled = false;
            }
        }
        /// <summary>
        /// Creates a groubox that controls that only one radiobutton can be selected at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(LowButton);
            groupBox1.Controls.Add(MediumButton);
            groupBox1.Controls.Add(HighButton);
            Controls.Add(groupBox1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Today)
                addNewTask.Enabled = true;
        }
    }
}