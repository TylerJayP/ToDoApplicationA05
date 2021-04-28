using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ToDoApplication
{
    /// <summary>
    /// Editing Task Form Start
    /// </summary>
    public partial class EditTaskPage : Form
    {
        public int cbIndex;
        public int lbIndex;
        /// <summary>
        /// Passing in the index of ComboBox and ListBox to set later for editing tasks based on those indexes.
        /// </summary>
        /// <param name="comboBoxIndex"></param>
        /// <param name="listBoxIndex"></param>
        public EditTaskPage(int comboBoxIndex, int listBoxIndex)
        {
            InitializeComponent();
            this.Text = "Update Task";
            cbIndex = comboBoxIndex;
            lbIndex = listBoxIndex;

            // comboIndex determines which task list is selected
            // lbIndex determines which task of the list is selected
            // Had to make the task lists public static in order to get the data from different forms for easier data processing
            if (cbIndex == 0 && Homepage.currentTasks.Count != 0)
            {
                EditNameBox.Text = Homepage.currentTasks[lbIndex].Name;
                EditInfoBox.Text = Homepage.currentTasks[lbIndex].info;
                EditDateBox.Value = Homepage.currentTasks[lbIndex].dt;

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
            if (cbIndex == 1 && Homepage.previousTasks.Count != 0)
            {
                EditNameBox.Text = Homepage.previousTasks[lbIndex].Name;
                EditInfoBox.Text = Homepage.previousTasks[lbIndex].info;
                EditDateBox.Value = Homepage.previousTasks[lbIndex].dt;

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
            if (cbIndex == 2 && Homepage.upcomingTasks.Count != 0)
            {
                EditNameBox.Text = Homepage.upcomingTasks[lbIndex].Name;
                EditInfoBox.Text = Homepage.upcomingTasks[lbIndex].info;
                EditDateBox.Value = Homepage.upcomingTasks[lbIndex].dt;

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



        /// <summary>
        /// Allowing user to update task that is currently selected in Homepage and getting the index on which combobox and listbox is being used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void updateButton_Click(object sender, EventArgs e)
        {
            DateTime dt = EditDateBox.Value;
            string name = EditNameBox.Text;
            string info = EditInfoBox.Text;
            Priority p;

            //Pretty much the reverse of logic above in the EditTaskPage method
            if (cbIndex == 0)
            {               
                Homepage.currentTasks[lbIndex].Name = EditNameBox.Text;
                Homepage.currentTasks[lbIndex].info = EditInfoBox.Text;
                if (lowPriority.Checked == true)
                {
                    Homepage.currentTasks[lbIndex].p = Priority.LOW;
                }

                else if (mediumPriority.Checked == true)
                {
                    Homepage.currentTasks[lbIndex].p = Priority.MEDIUM;
                }
                else
                {
                    Homepage.currentTasks[lbIndex].p = Priority.HIGH;
                }
                switch (EditDateBox.Value.CompareTo(Homepage.currentTasks[lbIndex].dt))
                {
                    case 1:
                        Homepage.upcomingTasks.Add(new Task(EditNameBox.Text, EditDateBox.Value, Homepage.currentTasks[lbIndex].p, EditInfoBox.Text));
                        Homepage.currentTasks.RemoveAt(lbIndex);
                        break;
                    case -1:
                        Program.home.errorMessage("Date was not changed, as it was before the current date. Sorry, beautiful.");
                        break;
                    default:
                        Homepage.currentTasks[lbIndex].dt = EditDateBox.Value;
                        break;
                }
                this.Close();
            }

            //Previous Task
            if (cbIndex == 1)
            {
                Program.home.errorMessage("Can not edit previous task information");
                this.Close();
            }

            //Upcoming Task
            if (cbIndex == 2)
            {
                Homepage.upcomingTasks[lbIndex].Name = EditNameBox.Text;
                Homepage.upcomingTasks[lbIndex].info = EditInfoBox.Text;
                if (lowPriority.Checked == true)
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.LOW;
                }
                else if (mediumPriority.Checked == true)
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.MEDIUM;
                }
                else
                {
                    Homepage.upcomingTasks[lbIndex].p = Priority.HIGH;
                }
                switch (EditDateBox.Value.CompareTo(Homepage.currentTasks[lbIndex].dt))
                {
                    case 1:
                        Homepage.upcomingTasks[lbIndex].dt = EditDateBox.Value;
                        break;
                    case -1:
                        if (EditDateBox.Value < DateTime.Today)
                            Program.home.errorMessage("Date was not changed, as it was before the current date. Sorry, beautiful.");
                        else
                            Homepage.upcomingTasks[lbIndex].dt = EditDateBox.Value;
                        break;
                    default:
                        Homepage.currentTasks.Add(new Task(EditNameBox.Text, EditDateBox.Value, Homepage.currentTasks[lbIndex].p, EditInfoBox.Text));
                        Homepage.upcomingTasks.RemoveAt(lbIndex);
                        break;
                }
                this.Close();
            }
        }
    }
}
