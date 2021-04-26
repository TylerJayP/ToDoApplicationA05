using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ToDoApplication
{
    public partial class EditTaskPage : Form
    {
        public int cbIndex;
        public int lbIndex;
        public EditTaskPage(int comboBoxIndex, int listBoxIndex)
        {
            InitializeComponent();
            this.Text = "Update Task";
            cbIndex = comboBoxIndex;
            lbIndex = listBoxIndex;
            // comboIndex determines which task list is selected
            // lbIndex determines which task of the list is selected
            // Had to make the task lists public static in order to get the data from different forms for easier data processing
            if (cbIndex == 0 && Homepage.currentTasks.Any())
            {
                taskName.Text = Homepage.currentTasks[lbIndex].Name;
                richTextBox1.Text = Homepage.currentTasks[lbIndex].info;
                dateTimePicker.Value = Homepage.currentTasks[lbIndex].dt;

                if (Homepage.currentTasks[lbIndex].p == Priority.LOW)
                {
                    lowPriority.Checked = true;
                }
                else if (Homepage.currentTasks[lbIndex].p == Priority.MEDIUM)
                {
                    mediumPriority.Checked = true;
                }
                else
                    highPriority.Checked = true;
            }

            if (cbIndex == 1 && Homepage.previousTasks.Any())
            {
                taskName.Text = Homepage.previousTasks[lbIndex].Name;
                richTextBox1.Text = Homepage.previousTasks[lbIndex].info;
                dateTimePicker.Value = Homepage.previousTasks[lbIndex].dt;

                if (Homepage.previousTasks[lbIndex].p == Priority.LOW)
                {
                    lowPriority.Checked = true;
                }
                else if (Homepage.previousTasks[lbIndex].p == Priority.MEDIUM)
                {
                    mediumPriority.Checked = true;
                }
                else
                    highPriority.Checked = true;
            }

            if (cbIndex == 2 && Homepage.upcomingTasks.Any())
            {
                taskName.Text = Homepage.upcomingTasks[lbIndex].Name;
                richTextBox1.Text = Homepage.upcomingTasks[lbIndex].info;
                dateTimePicker.Value = Homepage.upcomingTasks[lbIndex].dt;

                if (Homepage.upcomingTasks[lbIndex].p == Priority.LOW)
                {
                    lowPriority.Checked = true;
                }
                else if (Homepage.upcomingTasks[lbIndex].p == Priority.MEDIUM)
                {
                    mediumPriority.Checked = true;
                }
                else
                    highPriority.Checked = true;
            }
        }

        public void updateButton_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker.Value;
            string name = taskName.Text;
            string info = richTextBox1.Text;
            Priority p;

            //Pretty much the reverse of logic above in the EditTaskPage method
            if (cbIndex == 0)
            {               
                Homepage.currentTasks[lbIndex].Name = taskName.Text;
                Homepage.currentTasks[lbIndex].info = richTextBox1.Text;
                Homepage.currentTasks[lbIndex].dt = dateTimePicker.Value;

                if (lowPriority.Checked == true)
                {
                    Homepage.currentTasks[lbIndex].p = Priority.LOW;
                    this.Close();
                }

                else if (mediumPriority.Checked == true)
                {
                    Homepage.currentTasks[lbIndex].p = Priority.MEDIUM;
                    this.Close();
                }
                else
                {
                    Homepage.currentTasks[lbIndex].p = Priority.HIGH;
                    this.Close();
                }
            }

            if (cbIndex == 1)
            {
                Homepage.previousTasks[lbIndex].Name = taskName.Text;
                Homepage.previousTasks[lbIndex].info = richTextBox1.Text;
                Homepage.previousTasks[lbIndex].dt = dateTimePicker.Value;

                if (lowPriority.Checked == true)
                {
                    Homepage.previousTasks[lbIndex].p = Priority.LOW;
                    this.Close();
                }
                else if (mediumPriority.Checked == true)
                {
                    Homepage.previousTasks[lbIndex].p = Priority.MEDIUM;
                    this.Close();
                }
                else
                {
                    Homepage.previousTasks[lbIndex].p = Priority.HIGH;
                    this.Close();
                }
            }

            if (cbIndex == 2)
            {

                Homepage.upcomingTasks[lbIndex].Name = taskName.Text;
                Homepage.upcomingTasks[lbIndex].info = richTextBox1.Text;
                Homepage.upcomingTasks[lbIndex].dt = dateTimePicker.Value;

                if (lowPriority.Checked == true)
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.LOW;
                    this.Close();
                }
                else if (mediumPriority.Checked == true)
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.MEDIUM;
                    this.Close();
                }
                else
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.HIGH;
                    this.Close();
                }
            }

            if (lowPriority.Checked == true)
                p = Priority.LOW;
            else if (mediumPriority.Checked == true)
                p = Priority.MEDIUM;
            else
                p = Priority.HIGH;

            // Adds and delete tasks if edited date is changed
            if (dt.Date > DateTime.Today)
            {
                Homepage.currentTasks.RemoveAt(lbIndex);
                Program.home.AddUpcomingTask(new Task(name, dt, p, info));
                this.Close();
            }
            else if(dt.Date == DateTime.Today)
            {
                Homepage.upcomingTasks.RemoveAt(lbIndex);
                Program.home.AddCurrentTask(new Task(name, dt, p, info));
                this.Close();
            }
        }
            //Date
            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            //User Task information
            private void richTextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void lowPriority_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void mediumPriority_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void highPriority_CheckedChanged(object sender, EventArgs e)
            {

            }
        }
    }
