
namespace ToDoApplication
{
    partial class EditTaskPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lowPriority = new System.Windows.Forms.RadioButton();
            this.mediumPriority = new System.Windows.Forms.RadioButton();
            this.highPriority = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task";
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskName.Location = new System.Drawing.Point(129, 45);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(201, 23);
            this.taskName.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(130, 85);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lowPriority
            // 
            this.lowPriority.AutoSize = true;
            this.lowPriority.Location = new System.Drawing.Point(136, 124);
            this.lowPriority.Name = "lowPriority";
            this.lowPriority.Size = new System.Drawing.Size(14, 13);
            this.lowPriority.TabIndex = 7;
            this.lowPriority.TabStop = true;
            this.lowPriority.UseVisualStyleBackColor = true;
            this.lowPriority.CheckedChanged += new System.EventHandler(this.lowPriority_CheckedChanged);
            // 
            // mediumPriority
            // 
            this.mediumPriority.AutoSize = true;
            this.mediumPriority.Location = new System.Drawing.Point(185, 124);
            this.mediumPriority.Name = "mediumPriority";
            this.mediumPriority.Size = new System.Drawing.Size(14, 13);
            this.mediumPriority.TabIndex = 8;
            this.mediumPriority.TabStop = true;
            this.mediumPriority.UseVisualStyleBackColor = true;
            this.mediumPriority.CheckedChanged += new System.EventHandler(this.mediumPriority_CheckedChanged);
            // 
            // highPriority
            // 
            this.highPriority.AutoSize = true;
            this.highPriority.Location = new System.Drawing.Point(231, 124);
            this.highPriority.Name = "highPriority";
            this.highPriority.Size = new System.Drawing.Size(14, 13);
            this.highPriority.TabIndex = 9;
            this.highPriority.TabStop = true;
            this.highPriority.UseVisualStyleBackColor = true;
            this.highPriority.CheckedChanged += new System.EventHandler(this.highPriority_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(129, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(167, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Medium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(220, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "High";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(129, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 67);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Lime;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(113, 251);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(134, 28);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Task";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EditTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.highPriority);
            this.Controls.Add(this.mediumPriority);
            this.Controls.Add(this.lowPriority);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "EditTaskPage";
            this.Text = "Low";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton lowPriority;
        private System.Windows.Forms.RadioButton mediumPriority;
        private System.Windows.Forms.RadioButton highPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button updateButton;
    }
}