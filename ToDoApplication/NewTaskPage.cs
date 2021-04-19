using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class NewTaskPage : Form
    {
        Homepage infoForm1 = new();
        public NewTaskPage()
        {
            InitializeComponent();
            this.Text = "New ToDo";
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void button1_Click(object sender, EventArgs e)
        {


        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string taskInfo;
            taskInfo = richTextBox1.Text;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userTaskName;
            userTaskName = taskName.Text;
           
        }
        
    }
}
