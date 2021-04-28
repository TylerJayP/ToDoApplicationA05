using System;
using System.Windows.Forms;

namespace ToDoApplication
{
    /// <summary>
    /// Creates GUI page for user to edit a selected task
    /// </summary>
    public partial class EditTaskPage : Form
    {
        public int cbIndex;
        public int lbIndex;

        /// <summary>
        /// Passes in the index of ComboBox and ListBox to set later for editing tasks based on those indexes.
        /// </summary>
        /// <param name="comboBoxIndex"></param>
        /// <param name="listBoxIndex"></param>
        public EditTaskPage(int comboBoxIndex, int listBoxIndex)
        {
            InitializeComponent();
            this.Text = "Update Task";
            cbIndex = comboBoxIndex;
            lbIndex = listBoxIndex;

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
        /// Allows user to update task that is currently selected in Homepage, and gets the index on which drop down text box and listbox is being used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void updateButton_Click(object sender, EventArgs e)
        {
            DateTime dt = EditDateBox.Value;
            string name = EditNameBox.Text;
            string info = EditInfoBox.Text;

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
                        Program.home.ErrorMessage("Date was not changed, as it was before the current date. Sorry, beautiful.");
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
                Program.home.ErrorMessage("Can not edit previous task information");
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
                            Program.home.ErrorMessage("Date was not changed, as it was before the current date. Sorry, beautiful.");
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
