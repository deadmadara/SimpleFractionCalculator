using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFractionCalculator
{
    public partial class Form1 : Form
    {
        Fraction call;
        public Form1()
        {
            InitializeComponent();
            call = new Fraction();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            textBox1.Text = call.handle(text);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print example, format 'a/b+c/d', then press '='\nAvailable operations: '+', '-', '*', ':'");
        }
    }
}
