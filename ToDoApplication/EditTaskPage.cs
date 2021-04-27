﻿using System;
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
            if (cbIndex == 0 && Homepage.currentTasks.Any())
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
            if (cbIndex == 1 && Homepage.previousTasks.Any())
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
            if (cbIndex == 2 && Homepage.upcomingTasks.Any())
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
                Homepage.currentTasks[lbIndex].dt = EditDateBox.Value;

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
                Homepage.previousTasks[lbIndex].Name = EditNameBox.Text;
                Homepage.previousTasks[lbIndex].info = EditInfoBox.Text;
                Homepage.previousTasks[lbIndex].dt = EditDateBox.Value;

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
                Homepage.upcomingTasks[lbIndex].Name = EditNameBox.Text;
                Homepage.upcomingTasks[lbIndex].info = EditInfoBox.Text;
                Homepage.upcomingTasks[lbIndex].dt = EditDateBox.Value;
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
            if (dt.Date > DateTime.Today && Homepage.currentTasks.Any())
            { 
                Homepage.currentTasks.RemoveAt(lbIndex);
                Program.home.AddUpcomingTask(new Task(name, dt, p, info));
                this.Close();
            }
            else if(dt.Date == DateTime.Today && Homepage.upcomingTasks.Any())
            {
                Homepage.upcomingTasks.RemoveAt(lbIndex);
                Program.home.AddCurrentTask(new Task(name, dt, p, info));
                this.Close();
            }
        }
    }
}
