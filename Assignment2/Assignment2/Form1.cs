using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public string firstNumber = string.Empty;
        public string secondNumber = string.Empty;
        public string operation = string.Empty;
        public string result = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            firstNumber = firstnumbertextBox.Text;
            secondNumber = secondnumbertextBox.Text;
            operation = operatorcomboBox.SelectedItem.ToString();
            labelResult.Visible = true;
            resulttextBox.Visible = true;
            resulttextBox.Text = Program.ComputeOperation(firstNumber, secondNumber, operation);
        }
    }
}
