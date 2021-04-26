
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CompleteTask = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.RemoveTask = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(195, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Things To Do";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current Tasks",
            "Previous Tasks",
            "Upcoming Tasks"});
            this.comboBox1.Location = new System.Drawing.Point(355, 96);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 36);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select Tasks To View";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CompleteTask
            // 
            this.CompleteTask.AccessibleName = "CompleteTask";
            this.CompleteTask.BackColor = System.Drawing.Color.Goldenrod;
            this.CompleteTask.FlatAppearance.BorderSize = 5;
            this.CompleteTask.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompleteTask.ForeColor = System.Drawing.Color.Black;
            this.CompleteTask.Location = new System.Drawing.Point(328, 537);
            this.CompleteTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompleteTask.Name = "CompleteTask";
            this.CompleteTask.Size = new System.Drawing.Size(246, 90);
            this.CompleteTask.TabIndex = 3;
            this.CompleteTask.Text = "COMPLETED";
            this.CompleteTask.UseVisualStyleBackColor = false;
            this.CompleteTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Location = new System.Drawing.Point(318, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.Location = new System.Drawing.Point(416, 279);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.Tan;
            this.InfoBox.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBox.ForeColor = System.Drawing.Color.Black;
            this.InfoBox.Location = new System.Drawing.Point(250, 330);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(407, 180);
            this.InfoBox.TabIndex = 7;
            this.InfoBox.Text = "TASK INFO WILL APPEAR HERE";
            this.InfoBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // RemoveTask
            // 
            this.RemoveTask.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveTask.Location = new System.Drawing.Point(506, 279);
            this.RemoveTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveTask.Name = "RemoveTask";
            this.RemoveTask.Size = new System.Drawing.Size(79, 31);
            this.RemoveTask.TabIndex = 9;
            this.RemoveTask.Text = "REMOVE";
            this.RemoveTask.UseVisualStyleBackColor = false;
            this.RemoveTask.Click += new System.EventHandler(this.RemoveTask_Click);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Tan;
            this.listBox4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox4.ForeColor = System.Drawing.Color.Black;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 26;
            this.listBox4.Location = new System.Drawing.Point(319, 147);
            this.listBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(267, 108);
            this.listBox4.TabIndex = 12;
            this.listBox4.Visible = false;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.Silver;
            this.DateLabel.Location = new System.Drawing.Point(12, 111);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(76, 31);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "label2";
            this.DateLabel.Click += new System.EventHandler(this.Form1_Load);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.TimeLabel.Location = new System.Drawing.Point(15, 147);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 20);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "label3";
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
            this.ClientSize = new System.Drawing.Size(887, 662);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.RemoveTask);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CompleteTask);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CompleteTask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button RemoveTask;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

