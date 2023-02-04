using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCD_HCF_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLCD_Click(object sender, EventArgs e)
        {
            try
            {
                txtLCDResult.Text = LCD.LowestCommonMultiple(int.Parse(txtLCDnum1.Text), int.Parse(txtLCDnum2.Text)).ToString();
            }
            catch (Exception msg)
            {

                MessageBox.Show("Please enter the correct numbers, " + msg.Message);
            }
            
        }

        private void btnHCF_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtHCFresult.Text = HCF.HCD(int.Parse(txtHCFnum1.Text), int.Parse(txtHCFnum2.Text)).ToString();
            }
            catch (Exception msg)
            {

                MessageBox.Show("Please enter the correct numbers, " + msg.Message);
            }
        }

        private void btnLCDclear_Click(object sender, EventArgs e)
        {
            txtLCDnum1.Clear();
            txtLCDnum2.Clear();
            txtLCDResult.Clear();
        }

        private void btnHCFclear_Click(object sender, EventArgs e)
        {
            txtHCFnum1.Clear();
            txtHCFnum2.Clear();
            txtHCFresult.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
