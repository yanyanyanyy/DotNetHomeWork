using System;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(this.textBox1.Text.ToString());
            double num2 = double.Parse(this.textBox2.Text.ToString());
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.label2.Text = "" + (num1 + num2);
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                this.label2.Text = "" + (num1 - num2);
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.label2.Text = "" + (num1 * num2);
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                this.label2.Text = "" + (num1 / num2);
            }
            else
            {
                this.label2.Text = "" + (num1 + num2);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
