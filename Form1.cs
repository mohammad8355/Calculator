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
        ICalculator calculate;
        public Form1()
        {
            calculate = new Calculator();
            InitializeComponent();
        }
        
        string value = "";
             bool isoperated = false;
        private void button_Click(object sender, EventArgs e)
        {
            if(txtb.Text=="0" || isoperated)
            {
                txtb.Clear();
            }
            isoperated = false;
            Button button = (Button)sender;
            txtb.Text += button.Text;
         
        }


        string Operator = "";
 
        private void btnplus_Click(object sender, EventArgs e)
        {
            
            Button btnplus = (Button)sender;
            
            if (value !="")
            {
               
                    btnequal.PerformClick();     
                    Operator = btnplus.Text;
                isoperated = true;
            }
            else
            {
                value = txtb.Text;
                Operator = btnplus.Text;
                txtb.Text = "";
                isoperated = true;
                
            }
            
        }
  
         private void btnequal_Click(object sender, EventArgs e)
        {
        switch (Operator)
            {
                case "+":
                   string sum= Convert.ToString(calculate.Plus(int.Parse(value), int.Parse(txtb.Text)));
                    txtb.Text = sum;
                    value = "";
                    break;
                case "-":
                   string minus = Convert.ToString(calculate.Minus(int.Parse(value), int.Parse(txtb.Text)));
                    txtb.Text = minus;              
                    value = "";
                    break;
                case "*":
                    string multiple=Convert.ToString(calculate.Multiple(int.Parse(value), int.Parse(txtb.Text)));
                    txtb.Text = multiple;                 
                    value = "";
                    break;
                case "/":
                    string divide=Convert.ToString(calculate.Divide(int.Parse(value), int.Parse(txtb.Text)));
                    txtb.Text = divide;           
                    value = "";
                    break;
            }
            value =txtb.Text;
           

        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtb.Text = "";
            value = "";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtb.Text = "";
        }

        private void btnhover(object sender, EventArgs e)
        {
            Button btnhover = (Button)sender;
            btnhover.ForeColor = Color.White;
        }

        private void btnleave(object sender, EventArgs e)
        {
            Button btnleave = (Button)sender;
            btnleave.ForeColor = Color.Black;
        }
    }
}
