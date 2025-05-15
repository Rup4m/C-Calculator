using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculations = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentCalculations += ((Button)sender).Text;
            txtOutput.Text = currentCalculations;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
           string formattedCalculations=currentCalculations.ToString();
            try { 
 txtOutput.Text=new DataTable().Compute(formattedCalculations, null).ToString();
                currentCalculations = txtOutput.Text;
            }
            catch (Exception ex)
            {
                txtOutput.Text = "Error";
                currentCalculations = "";
            }
        }
        private void button_clear_click(object sender, EventArgs e)
        {
            currentCalculations = "";
            txtOutput.Text = "0";
        }
        private void button_clearEntry_click(object sender, EventArgs e)
        {
            if (currentCalculations.Length > 0)
            {
                currentCalculations = currentCalculations.Remove(currentCalculations.Length - 1);
                txtOutput.Text = currentCalculations;
            }
            else
            {
                txtOutput.Text = "0";
            }
        }
    }
}
