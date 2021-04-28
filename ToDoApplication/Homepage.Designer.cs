
namespace ToDoApplication
{
     partial class Homepage
     {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.taskDisplayDropdown = new System.Windows.Forms.ComboBox();
            this.CompleteTaskButton = new System.Windows.Forms.Button();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.SelectableTaskList = new System.Windows.Forms.ListBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ToDoLabel.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDoLabel.ForeColor = System.Drawing.Color.Snow;
            this.ToDoLabel.Location = new System.Drawing.Point(296, 25);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(307, 51);
            this.ToDoLabel.TabIndex = 1;
            this.ToDoLabel.Text = "Things To Do";
            // 
            // taskDisplayDropdown
            // 
            this.taskDisplayDropdown.BackColor = System.Drawing.Color.PapayaWhip;
            this.taskDisplayDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskDisplayDropdown.FormattingEnabled = true;
            this.taskDisplayDropdown.Items.AddRange(new object[] {
            "Current Tasks",
            "Previous Tasks",
            "Upcoming Tasks"});
            this.taskDisplayDropdown.Location = new System.Drawing.Point(355, 96);
            this.taskDisplayDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskDisplayDropdown.Name = "taskDisplayDropdown";
            this.taskDisplayDropdown.Size = new System.Drawing.Size(199, 36);
            this.taskDisplayDropdown.TabIndex = 2;
            this.taskDisplayDropdown.Text = "Select Tasks To View";
            this.taskDisplayDropdown.SelectedIndexChanged += new System.EventHandler(this.TaskListDropdown_SelectedIndexChanged);
            // 
            // CompleteTaskButton
            // 
            this.CompleteTaskButton.AccessibleName = "CompleteTask";
            this.CompleteTaskButton.BackColor = System.Drawing.Color.ForestGreen;
            this.CompleteTaskButton.FlatAppearance.BorderSize = 5;
            this.CompleteTaskButton.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteTaskButton.ForeColor = System.Drawing.Color.Black;
            this.CompleteTaskButton.Location = new System.Drawing.Point(329, 549);
            this.CompleteTaskButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompleteTaskButton.Name = "CompleteTaskButton";
            this.CompleteTaskButton.Size = new System.Drawing.Size(246, 91);
            this.CompleteTaskButton.TabIndex = 3;
            this.CompleteTaskButton.Text = "COMPLETED!";
            this.CompleteTaskButton.UseVisualStyleBackColor = false;
            this.CompleteTaskButton.Click += new System.EventHandler(this.CompleteTask_Click);
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.BackColor = System.Drawing.Color.OliveDrab;
            this.NewTaskButton.Location = new System.Drawing.Point(250, 279);
            this.NewTaskButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(115, 43);
            this.NewTaskButton.TabIndex = 4;
            this.NewTaskButton.Text = "NEW";
            this.NewTaskButton.UseVisualStyleBackColor = false;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.BackColor = System.Drawing.Color.GreenYellow;
            this.EditTaskButton.Location = new System.Drawing.Point(401, 279);
            this.EditTaskButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(115, 43);
            this.EditTaskButton.TabIndex = 5;
            this.EditTaskButton.Text = "EDIT";
            this.EditTaskButton.UseVisualStyleBackColor = false;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskPageButton_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.Tan;
            this.InfoBox.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBox.ForeColor = System.Drawing.Color.Black;
            this.InfoBox.Location = new System.Drawing.Point(250, 347);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(407, 180);
            this.InfoBox.TabIndex = 7;
            this.InfoBox.Text = "TASK INFO WILL APPEAR HERE";
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveTaskButton.Location = new System.Drawing.Point(542, 279);
            this.RemoveTaskButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(115, 43);
            this.RemoveTaskButton.TabIndex = 9;
            this.RemoveTaskButton.Text = "REMOVE";
            this.RemoveTaskButton.UseVisualStyleBackColor = false;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTask_Click);
            // 
            // SelectableTaskList
            // 
            this.SelectableTaskList.BackColor = System.Drawing.Color.Tan;
            this.SelectableTaskList.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectableTaskList.ForeColor = System.Drawing.Color.Black;
            this.SelectableTaskList.FormattingEnabled = true;
            this.SelectableTaskList.ItemHeight = 26;
            this.SelectableTaskList.Location = new System.Drawing.Point(319, 147);
            this.SelectableTaskList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectableTaskList.Name = "SelectableTaskList";
            this.SelectableTaskList.Size = new System.Drawing.Size(267, 82);
            this.SelectableTaskList.TabIndex = 12;
            this.SelectableTaskList.SelectedIndexChanged += new System.EventHandler(this.SelectableTaskList_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateLabel.Location = new System.Drawing.Point(11, 111);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 31);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Click += new System.EventHandler(this.Form1_Load);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLabel.Location = new System.Drawing.Point(15, 147);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 20);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Click += new System.EventHandler(this.Form1_Load);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::ToDoApplication.Properties.Resources.woodshop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 661);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SelectableTaskList);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.NewTaskButton);
            this.Controls.Add(this.CompleteTaskButton);
            this.Controls.Add(this.taskDisplayDropdown);
            this.Controls.Add(this.ToDoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.ComboBox taskDisplayDropdown;
        private System.Windows.Forms.Button CompleteTaskButton;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.ListBox SelectableTaskList;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

