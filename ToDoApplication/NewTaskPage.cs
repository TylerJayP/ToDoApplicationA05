using System;
using System.Windows.Forms;

namespace ToDoApplication
{
    /// <summary>
    /// Creates a New Task Form that allows for creation of new Task object and populates its
    /// respective list in Homepage.
    /// </summary>
    public partial class NewTaskPage : Form
    {
        public NewTaskPage()
        {
            InitializeComponent();
            this.Text = "New Task";
        }

        /// <summary>
        /// Event handler that populates text from new task page form into Task object and respective Task list.
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
        /// Creates a grouping of radiobuttons, allowing for only one to be pressed at a time.
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

        /// <summary>
        /// Allows and disallows functionality of create new task button dependent upon whether
        /// date is current, upcoming, or previous.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Today)
                addNewTask.Enabled = true;
        }
    }
}