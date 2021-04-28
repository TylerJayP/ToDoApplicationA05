using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApplication
{ 
    /// <summary>
    /// Class that creates main GUI for To Do Application.
    /// </summary>
    public partial class Homepage : Form
    {
        public static List<Task> previousTasks { get; set; }
        public static List<Task> currentTasks { get; set; }
        public static List<Task> upcomingTasks { get; set; }

        /// <summary>
        /// Constructs new instance of homepage
        /// </summary>
        public Homepage()
        {
            previousTasks = new List<Task>();
            currentTasks = new List<Task>();
            upcomingTasks = new List<Task>();
            InitializeComponent();
            this.Text = "ToDo Application";
        }

        /// <summary>
        /// Helper method for updating upcoming tasks
        /// </summary>
        /// <param name="task"></param>
        public void AddUpcomingTask(Task task)
        {
            upcomingTasks.Add(task);
        }

        /// <summary>
        /// Helper method for updating current tasks
        /// </summary>
        /// <param name="task"></param>
        public void AddCurrentTask(Task task)
        {
            currentTasks.Add(task);
        }

        /// <summary>
        /// Loads the main GUI form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Moves task from either current Task list or upcoming Task list into previous Task list and
        /// Prints "Good Job!" when user completes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteTask_Click(object sender, EventArgs e)
        {
            //Takes task from either upcoming task or current task and deletes from those lists
            //Then adds it to previous 
            switch (taskDisplayDropdown.SelectedIndex)
            {
                //Current
                case 0:
                    if (SelectableTaskList.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else if (SelectableTaskList.SelectedItem != null && currentTasks.Any())
                    {
                        int selectedIndex = SelectableTaskList.SelectedIndex;
                        previousTasks.Add(currentTasks[selectedIndex]);
                        currentTasks.RemoveAt(selectedIndex);
                        SelectableTaskList.Items.RemoveAt(selectedIndex);

                        InfoBox.Text = "Great Job!";
                    }
                    else
                    {
                        InfoBox.Clear();
                    }
                    break;
                //Previous
                case 1:
                    break;
                //Upcoming
                case 2:
                    if (SelectableTaskList.SelectedItem == null)
                    {
                        InfoBox.Text = "Removed!";
                    }
                    else if (SelectableTaskList.SelectedItem != null && upcomingTasks.Any())
                    {
                        int selectedIndex = SelectableTaskList.SelectedIndex;
                        previousTasks.Add(upcomingTasks[selectedIndex]);
                        upcomingTasks.RemoveAt(selectedIndex);
                        SelectableTaskList.Items.RemoveAt(selectedIndex);

                        InfoBox.Text = "Great Job!";
                    }
                    else
                    {
                        InfoBox.Clear();
                    }
                    break;
            }
        }

        /// <summary>
        /// Opens NewTaskPage Form for user to create a new task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewTaskButton_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTaskPage();
            newTaskForm.Show();
        }

        /// <summary>
        /// Sees what index on the combobox is selected to determine which listbox we are viewing.
        /// Adding the specific text files based on comobox.
        /// Populating the listboxes with our textfile and sorting it based on date and then priority.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TaskListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = taskDisplayDropdown.SelectedIndex;

            //Clear box
            InfoBox.Clear();
            SelectableTaskList.Items.Clear();

            //Current Tasks
            if (selectedIndex == 0)
            {
                //Allow complete task button
                CompleteTaskButton.Enabled = true;

                //Sort current tasks
                currentTasks.Sort();

                //Print current tasks to box
                List<string> cnames = new List();
                foreach (Task t in currentTasks)
                {
                    cnames.Add(t.Name);
                }
                SelectableTaskList.Items.AddRange(cnames.ToArray());
            }

            //Previous Tasks
            if (selectedIndex == 1)
            {
                //Disallow complete task button
                CompleteTaskButton.Enabled = false;

                //Sort tasks
                previousTasks.Sort();

                //Print items to box
                List<string> pnames = new List();
                foreach (Task t in previousTasks)
                {
                    pnames.Add(t.Name);
                }
                SelectableTaskList.Items.AddRange(pnames.ToArray());

            }

            //Upcoming Tasks
            if (selectedIndex == 2)
            {
                //Allow complete task button
                CompleteTaskButton.Enabled = true;

                //Sort upcoming tasks
                upcomingTasks.Sort();

                //Print tasks to info box
                List<string> unames = new List();
                foreach (Task t in upcomingTasks)
                {
                    unames.Add(t.Name + " : " + t.dt.ToShortDateString());
                }
                SelectableTaskList.Items.AddRange(unames.ToArray());
            }
        }

        /// <summary>
        /// Opens EditTaskPage Form for user to edit a task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditTaskPageButton_Click(object sender, EventArgs e)
        {
            if (SelectableTaskList.SelectedIndex != -1)
            {
                var updateTaskForm = new EditTaskPage(taskDisplayDropdown.SelectedIndex, SelectableTaskList.SelectedIndex);
                updateTaskForm.Show();
            }
        }

        /// <summary>
        /// Removes the task from the selection list and removes it from the Task selector list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTask_Click(object sender, EventArgs e)
        {
            //Removing selected item(s) from Current Tasks
            ListBox.SelectedObjectCollection currentItems = new ListBox.SelectedObjectCollection(SelectableTaskList);
            currentItems = SelectableTaskList.SelectedItems;
            if (SelectableTaskList.SelectedIndex != -1 &&  taskDisplayDropdown.SelectedIndex == 0)
            {
                currentTasks.RemoveAt(SelectableTaskList.SelectedIndex);
                SelectableTaskList.Items.RemoveAt(SelectableTaskList.SelectedIndex);                         
            }
            //Removing selected item(s) from Previous Tasks
            ListBox.SelectedObjectCollection previousItems = new ListBox.SelectedObjectCollection(SelectableTaskList);
            previousItems = SelectableTaskList.SelectedItems;
            if (SelectableTaskList.SelectedIndex != -1 && taskDisplayDropdown.SelectedIndex == 1)
            {
                previousTasks.RemoveAt(SelectableTaskList.SelectedIndex);
                SelectableTaskList.Items.RemoveAt(SelectableTaskList.SelectedIndex);               
            }
            //Removing selected item(s) from Upcoming Tasks
            ListBox.SelectedObjectCollection upcomingItems = new ListBox.SelectedObjectCollection(SelectableTaskList);
            upcomingItems = SelectableTaskList.SelectedItems;
            if (SelectableTaskList.SelectedIndex != -1 && taskDisplayDropdown.SelectedIndex == 2)
            {
                upcomingTasks.RemoveAt(SelectableTaskList.SelectedIndex);
                SelectableTaskList.Items.RemoveAt(SelectableTaskList.SelectedIndex);              
            }
        }

        /// <summary>
        /// Prints the information from the specfic list into the richtextbox(infobox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectableTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoBox.Clear();
            int selectedIndex = SelectableTaskList.SelectedIndex;
            if (selectedIndex != -1)
            {
                switch (taskDisplayDropdown.SelectedIndex)
                {
                    //Current
                    case 0:
                        InfoBox.Text = currentTasks[selectedIndex].ToString();
                        break;
                    //Previous
                    case 1:
                        InfoBox.Text = previousTasks[selectedIndex].ToString();
                        break;
                    //Upcoming
                    case 2:
                        InfoBox.Text = upcomingTasks[selectedIndex].ToString();
                        break;
                }
            }
            
        }

        /// <summary>
        /// Creates a seconds timer to update clock label in main GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Prints all tasks into their respective .txt file.
        /// </summary>
        /// <param name="file"></param>
        public void PrintToFile(string file)
        {
            try
            {
                using (StreamWriter sw = new(file, false))
                {
                    if (file == "CurrentTasks.txt")
                    {
                        foreach (Task t in currentTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                    if (file == "PreviousTasks.txt")
                    {
                        foreach (Task t in previousTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                    if (file == "UpcomingTasks.txt")
                    {
                        foreach (Task t in upcomingTasks)
                        {
                            sw.WriteLine(string.Format("{0},{1},{2},{3}", t.Name, t.dt, t.p, t.info));
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("StreamWriter is not functioning correctly.");
            }
           
        }

        /// <summary>
        /// Reads three .txt files included in Resources and populates their respective Lists to be modified during
        /// application run time.
        /// in the correct places.
        /// </summary>
        /// <param name="file"></param>
        public void IntializeList(String file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] aligning = line.Split(',');
                        Priority priorityEnum;
                        switch (aligning[2])
                        {
                            case "LOW":
                                priorityEnum = Priority.LOW;
                                break;
                            case "MEDIUM":
                                priorityEnum = Priority.MEDIUM;
                                break;
                            default:
                                priorityEnum = Priority.HIGH;
                                break;
                        }
                        switch (file)
                        {
                            case "UpcomingTasks.txt":
                                upcomingTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            case "CurrentTasks.txt":
                                currentTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            case "PreviousTasks.txt":
                                previousTasks.Add(new Task(aligning[0], DateTime.Parse(aligning[1]), priorityEnum, aligning[3]));
                                break;
                            default: break;
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("StreamReader is not functioning correctly");
            }
            
        }
        
        /// <summary>
        /// Prints error message to infoBox
        /// </summary>
        /// <param name="s"></param>
        public void ErrorMessage(string s)
        {
            this.InfoBox.Text = s;
        }
    }
}
