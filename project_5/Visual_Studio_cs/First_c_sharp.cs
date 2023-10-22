using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            X2.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((X1.Text == "") || (Y1.Text == "") || (X2.Text == "") || (Y2.Text == ""))
            {
                MessageBox.Show("Invalid Input!");
            }
            else if ((X1.Text.All(c => Char.IsDigit(c) || c == '.')) && (X1.Text.All(c => Char.IsDigit(c) || c == '.')) && (X2.Text.All(c => Char.IsDigit(c) || c == '.')) && (Y2.Text.All(c => Char.IsDigit(c) || c == '.')))
            {
                double deltaX = double.Parse(X2.Text) - double.Parse(X1.Text);
                double deltaY = double.Parse(Y2.Text) - double.Parse(Y1.Text);

                double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                MessageBox.Show("Distance = " + distance.ToString());
            }
            else
            {
                MessageBox.Show("Inputs aren't Digits!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
