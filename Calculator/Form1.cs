using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = Convert.ToSingle(textBox1.Text);
            num2 = Convert.ToSingle(textBox2.Text);

            if (radioButton1.Checked)
            {
                result = num1 * num2;
                label1.Text = Convert.ToString(result);
            }
            else if (radioButton2.Checked)
            {
                result = num1 / num2;

                label1.Text = Convert.ToString(result);
            }
            else if (radioButton3.Checked)
            {
                result = num1 + num2;
                label1.Text = Convert.ToString(result);
            }
            else if (radioButton4.Checked)
            {
                result = num1 - num2;
                label1.Text = Convert.ToString(result);
            }
            else
            {
                label1.Text = "Впишите 2 числа и выберите действие";
            }
        }
    }
}
