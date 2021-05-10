using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator
{
    public partial class Form1 : Form
    {
        double h;
        double w;
        double t;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMI.BackColor = Color.White;

            h = Convert.ToDouble(Height.Text);
            w = Convert.ToDouble(Weight.Text);
            t = (w/h/h)*10000;
            BMI.Text = t.ToString("F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Height.Clear();
            Weight.Clear();
            BMI.Text = "";
            BMI.BackColor = Color.White;
        }


        private void Height_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
