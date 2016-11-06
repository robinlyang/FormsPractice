using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //has timers in it

namespace FormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            output += textBox1.Text + "\n";
            output += comboBox1.Text + "\n";
            output += dateTimePicker1.Value + "\n";
            output += numericUpDown1.Value + "\n";
            output += monthCalendar1.SelectionStart + "\n";
            output += listBox1.Text + "\n";
            pictureBox1.Image = 
                Image.FromFile(@"C:\Users\RobinY\Documents\NET One\Dog2.jpg");
            webBrowser1.Url = new Uri("https://reddit.com/");
            double amount = 1234.56;
            for (int x = 1; x <=3; x++)
            {
                //string nice = string.Format("{ 0,-5}{ 1, 10:c}", x, x * amount);
                //listBox1.Items.Add(nice);
            }
            progressBar1.Value = 0;
            for (int y = 1; y <=10; y++)
            {
                progressBar1.Value = 10 * y;
                Thread.Sleep(1000); //wait one second

            }

            MessageBox.Show(output);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("firefox.exe", "http://mantis.sait.ca/");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =
                Image.FromFile(@"C:\Users\RobinY\Documents\NET One\Dog2.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Hi there");
            listBox1.Items.Add("Hello");
            textBox1.Text = ("Robin");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }
    }
}
