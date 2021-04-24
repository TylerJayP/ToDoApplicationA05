using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ToDoApplication
{
    public partial class EditTaskPage : Form
    {
        public EditTaskPage(int comboIndex, int lbIndex)
        {
            InitializeComponent();
            this.Text = "Update Task";
            
            // comboIndex determines which task list is selected
            // lbIndex determines which task of the list is selected
            // Had to make the task lists public static in order to get the data from different forms for easier data processing
            if (comboIndex == 0 && Homepage.currentTasks.Any())
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

            if (comboIndex == 1 && Homepage.previousTasks.Any())
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

            if (comboIndex == 2 && Homepage.upcomingTasks.Any())
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

        private void updateButton_Click(object sender, EventArgs e)
        {

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
