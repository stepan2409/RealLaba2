using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealLaba2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            oper = new RealLaba2.Operator(this.textBox1.Text, this.numericUpDown1.Value, (int)this.numericUpDown2.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oper.Name = textBox1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            oper.Price = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            oper.UsersAmount = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculationResultLabel.Text = oper.CalculateIncome().ToString("N") + " р/мес"; 
        }
    }
}
