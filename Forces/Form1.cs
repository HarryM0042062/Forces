using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
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
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.00));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.00));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        double tan(double x)
        {
            return (Math.Cos(x * Math.PI / 180.00));
        }
        double atan(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                // reads the forces from both text boxes
                double Fx = double.Parse(richTextBox3.Text);
                double Fy = double.Parse(richTextBox4.Text);
                //
                double Force = Math.Sqrt(Fx*Fx+Fy*Fy);
                double Angle = Fy * atan(Fy/Fx);
                //
                label3.Text = "Force = " + Fx;
                label4.Text = "Angle = " + Fx;
            }
            catch
            {
                // show error message on screen
                MessageBox.Show("WRONG");
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

