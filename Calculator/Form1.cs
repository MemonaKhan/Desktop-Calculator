using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double r_value = 0;
        String opr = "";
        bool checkopr = false;
        bool check = false;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || checkopr)
            {
                textBox1.Clear();
                
            }
      
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            checkopr = false;
        }

        private void opr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (r_value != 0)
            {

                if (check)
                { r_value = 0; }
                button19.PerformClick();
                opr = button.Text;
                r_value = Double.Parse(textBox1.Text);
                //label1.Text = label1.Text + " " + Double.Parse(textBox1.Text) + opr;
                label1.Text = r_value + " " + opr;
                checkopr = true;
                check = false;
            }
            else
            {
                opr = button.Text;
                r_value = Double.Parse(textBox1.Text);
                checkopr = true;
                //label1.Text = label1.Text + " " + Double.Parse(textBox1.Text) + opr;
                label1.Text = r_value + " " + opr;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            r_value = 0;
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            label1.Text = label1.Text +" "+ Double.Parse(textBox1.Text);
            
                switch (opr)
                {
                    case "+":
                        {
                            //r_value = Double.Parse(textBox1.Text);
                            textBox1.Text = (r_value + Double.Parse(textBox1.Text)).ToString();
                            
                            break;
                        }
                    case "-":
                        {
                            textBox1.Text = (r_value - Double.Parse(textBox1.Text)).ToString();
                           // r_value = Double.Parse(textBox1.Text); 
                            break;
                        }
                    case "*":
                        {
                            textBox1.Text = (r_value * Double.Parse(textBox1.Text)).ToString();
                           // r_value = Double.Parse(textBox1.Text);
                            break;
                        }
                    case "/":
                        {
                            textBox1.Text = (r_value / Double.Parse(textBox1.Text)).ToString();
                           // r_value = Double.Parse(textBox1.Text);
                            break;
                        }
                    default:
                        break;
                        
                }
                r_value = Double.Parse(textBox1.Text);
                check = true;
        }
    }
}
