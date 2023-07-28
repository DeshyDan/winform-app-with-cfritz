using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app_with_cfritz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberButton_Click (object sender , EventArgs r)
        {
            var button = sender as Button;
            if (CalculatorScreen.Text == "0.")
            {
                CalculatorScreen.Text = button.Text;
            }
            else
            {
                CalculatorScreen.Text += button.Text;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
