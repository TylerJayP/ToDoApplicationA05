
namespace ToDoApplication
{
    partial class NewTaskPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaskInfo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addNewTask = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HighButton = new System.Windows.Forms.RadioButton();
            this.MediumButton = new System.Windows.Forms.RadioButton();
            this.LowButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Task";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PapayaWhip;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.PapayaWhip;
            this.dateTimePicker1.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 29);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Priority";
            // 
            // TaskInfo
            // 
            this.TaskInfo.BackColor = System.Drawing.Color.PapayaWhip;
            this.TaskInfo.Location = new System.Drawing.Point(140, 229);
            this.TaskInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TaskInfo.Name = "TaskInfo";
            this.TaskInfo.Size = new System.Drawing.Size(229, 88);
            this.TaskInfo.TabIndex = 12;
            this.TaskInfo.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Details";
            // 
            // addNewTask
            // 
            this.addNewTask.BackColor = System.Drawing.Color.Goldenrod;
            this.addNewTask.Location = new System.Drawing.Point(172, 333);
            this.addNewTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNewTask.Name = "addNewTask";
            this.addNewTask.Size = new System.Drawing.Size(162, 43);
            this.addNewTask.TabIndex = 14;
            this.addNewTask.Text = "Add New Task";
            this.addNewTask.UseVisualStyleBackColor = false;
            this.addNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 40);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name";
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.PapayaWhip;
            this.taskName.Location = new System.Drawing.Point(140, 75);
            this.taskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(229, 27);
            this.taskName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HighButton);
            this.groupBox1.Controls.Add(this.MediumButton);
            this.groupBox1.Controls.Add(this.LowButton);
            this.groupBox1.Location = new System.Drawing.Point(140, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 56);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(167, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "High";
            // 
            // HighButton
            // 
            this.HighButton.AutoSize = true;
            this.HighButton.Location = new System.Drawing.Point(177, 11);
            this.HighButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(17, 16);
            this.HighButton.TabIndex = 14;
            this.HighButton.TabStop = true;
            this.HighButton.UseVisualStyleBackColor = true;
            // 
            // MediumButton
            // 
            this.MediumButton.AutoSize = true;
            this.MediumButton.Location = new System.Drawing.Point(105, 11);
            this.MediumButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(17, 16);
            this.MediumButton.TabIndex = 13;
            this.MediumButton.TabStop = true;
            this.MediumButton.UseVisualStyleBackColor = true;
            // 
            // LowButton
            // 
            this.LowButton.AutoSize = true;
            this.LowButton.Location = new System.Drawing.Point(32, 11);
            this.LowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(17, 16);
            this.LowButton.TabIndex = 12;
            this.LowButton.TabStop = true;
            this.LowButton.UseVisualStyleBackColor = true;
            // 
            // NewTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoApplication.Properties.Resources.darkwood;
            this.ClientSize = new System.Drawing.Size(512, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addNewTask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TaskInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewTaskPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medium";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TaskInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addNewTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton HighButton;
        private System.Windows.Forms.RadioButton MediumButton;
        private System.Windows.Forms.RadioButton LowButton;
    }
}