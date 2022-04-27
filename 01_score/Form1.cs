using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_score
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(textBox1.Text) + double.Parse(textBox2.Text) +
                double.Parse(textBox3.Text);
            double avg = sum / 3;

            textBox4.Text = sum.ToString();
            textBox5.Text = avg.ToString("0.0");
        }
    }
}
