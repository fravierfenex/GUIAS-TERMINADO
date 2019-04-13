using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 0;
            a = float.Parse(textBox1.Text) + float.Parse(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = 0;
            a = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0;
            a = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = 0;
            a = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text;
            textBox2.Text = textBox4.Text;
            textBox3.Text = textBox4.Text;
        }

    }
}
