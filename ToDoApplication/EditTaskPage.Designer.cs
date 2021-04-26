
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
            this.EditTaskLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.EditDateBox = new System.Windows.Forms.DateTimePicker();
            this.lowPriority = new System.Windows.Forms.RadioButton();
            this.mediumPriority = new System.Windows.Forms.RadioButton();
            this.highPriority = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditInfoBox = new System.Windows.Forms.RichTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.EditNameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.PriorityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditTaskLabel
            // 
            this.EditTaskLabel.AutoSize = true;
            this.EditTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditTaskLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditTaskLabel.Location = new System.Drawing.Point(162, 9);
            this.EditTaskLabel.Name = "EditTaskLabel";
            this.EditTaskLabel.Size = new System.Drawing.Size(180, 39);
            this.EditTaskLabel.TabIndex = 0;
            this.EditTaskLabel.Text = "Edit Task";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(27, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 40);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(27, 112);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(72, 40);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriorityLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriorityLabel.Location = new System.Drawing.Point(24, 175);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(109, 40);
            this.PriorityLabel.TabIndex = 3;
            this.PriorityLabel.Text = "Priority";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.BackColor = System.Drawing.Color.MistyRose;
            this.DetailsLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsLabel.ForeColor = System.Drawing.Color.Black;
            this.DetailsLabel.Location = new System.Drawing.Point(27, 263);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(96, 40);
            this.DetailsLabel.TabIndex = 4;
            this.DetailsLabel.Text = "Details";
            // 
            // EditDateBox
            // 
            this.EditDateBox.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditDateBox.Location = new System.Drawing.Point(129, 117);
            this.EditDateBox.Name = "EditDateBox";
            this.EditDateBox.Size = new System.Drawing.Size(279, 29);
            this.EditDateBox.TabIndex = 6;
            this.EditDateBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lowPriority
            // 
            this.lowPriority.AutoSize = true;
            this.lowPriority.Location = new System.Drawing.Point(27, 16);
            this.lowPriority.Name = "lowPriority";
            this.lowPriority.Size = new System.Drawing.Size(17, 16);
            this.lowPriority.TabIndex = 7;
            this.lowPriority.TabStop = true;
            this.lowPriority.UseVisualStyleBackColor = true;
            this.lowPriority.CheckedChanged += new System.EventHandler(this.lowPriority_CheckedChanged);
            // 
            // mediumPriority
            // 
            this.mediumPriority.AutoSize = true;
            this.mediumPriority.Location = new System.Drawing.Point(114, 16);
            this.mediumPriority.Name = "mediumPriority";
            this.mediumPriority.Size = new System.Drawing.Size(17, 16);
            this.mediumPriority.TabIndex = 8;
            this.mediumPriority.TabStop = true;
            this.mediumPriority.UseVisualStyleBackColor = true;
            this.mediumPriority.CheckedChanged += new System.EventHandler(this.mediumPriority_CheckedChanged);
            // 
            // highPriority
            // 
            this.highPriority.AutoSize = true;
            this.highPriority.Location = new System.Drawing.Point(196, 16);
            this.highPriority.Name = "highPriority";
            this.highPriority.Size = new System.Drawing.Size(17, 16);
            this.highPriority.TabIndex = 9;
            this.highPriority.TabStop = true;
            this.highPriority.UseVisualStyleBackColor = true;
            this.highPriority.CheckedChanged += new System.EventHandler(this.highPriority_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(93, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Medium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(187, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "High";
            // 
            // EditInfoBox
            // 
            this.EditInfoBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.EditInfoBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditInfoBox.Location = new System.Drawing.Point(129, 229);
            this.EditInfoBox.Name = "EditInfoBox";
            this.EditInfoBox.Size = new System.Drawing.Size(247, 99);
            this.EditInfoBox.TabIndex = 13;
            this.EditInfoBox.Text = "";
            this.EditInfoBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Goldenrod;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(162, 334);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(168, 47);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Task";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EditNameBox
            // 
            this.EditNameBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.EditNameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditNameBox.Location = new System.Drawing.Point(129, 71);
            this.EditNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditNameBox.Name = "EditNameBox";
            this.EditNameBox.Size = new System.Drawing.Size(247, 30);
            this.EditNameBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(413, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.BackColor = System.Drawing.Color.PapayaWhip;
            this.PriorityGroup.Controls.Add(this.lowPriority);
            this.PriorityGroup.Controls.Add(this.mediumPriority);
            this.PriorityGroup.Controls.Add(this.highPriority);
            this.PriorityGroup.Controls.Add(this.label6);
            this.PriorityGroup.Controls.Add(this.label8);
            this.PriorityGroup.Controls.Add(this.label7);
            this.PriorityGroup.Location = new System.Drawing.Point(129, 159);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(247, 64);
            this.PriorityGroup.TabIndex = 18;
            this.PriorityGroup.TabStop = false;
            // 
            // EditTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoApplication.Properties.Resources.woodandtools;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 393);
            this.Controls.Add(this.PriorityGroup);
            this.Controls.Add(this.EditNameBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.EditInfoBox);
            this.Controls.Add(this.EditDateBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EditTaskLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditTaskPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Low";
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditTaskLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.DateTimePicker EditDateBox;
        private System.Windows.Forms.RadioButton lowPriority;
        private System.Windows.Forms.RadioButton mediumPriority;
        private System.Windows.Forms.RadioButton highPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox EditInfoBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox EditNameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox PriorityGroup;
    }
}