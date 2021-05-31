using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_calculataor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, tip;
            int people;

           

            tip = Int32.Parse(numericUpDown1.Value.ToString());

           
            

            try
            {
                total = Double.Parse(textBox1.Text);
                if(total > 1000000)
                {
                    textBox2.Text = "$ " + "Null";
                    textBox3.Text = "$ " + "Null";
                    textBox4.Text = "Unrealistic Situation For Meal In Hotel Exceeding This Amount";
                    return;
                }
               
            } catch(Exception et)
            {
                
                textBox2.Text = "$ " + "Null";
                textBox3.Text = "$ " + "Null";
                textBox4.Text = " "+ et;
                return ;
            }

            people = Int32.Parse(numericUpDown2.Value.ToString());

            if (people == 0)
            {
                textBox2.Text = "$ " +"N/A";
                textBox3.Text = "$ " + "N/A";
                textBox4.Text = "Number of people Should be greater than equal to 1 : Invalid Bill .";
                return;

            }

            tip = tip * total / 100;

            total += tip;
            tip = tip / people;
            total = total / people;


            if(radioButton3.Checked == true)
            {
                if (tip == 0)
                {
                    textBox2.Text = "$ " + "0";
                }
                else
                {
                    textBox2.Text = "$ " + Math.Round(tip);
                }

                //show calculated total per person

                textBox3.Text = "$ " + total.ToString("0.00");

            }
            else if(radioButton2.Checked == true)
            {
                if (tip == 0)
                {
                    textBox2.Text = "$ " + "0";
                }
                else
                {
                    textBox2.Text = "$ " + tip.ToString("0.00");
                }

                //show calculated total per person

                textBox3.Text = "$ " + Math.Round(total);
            }
            else if(radioButton1.Checked == true)
            {
                if (tip == 0)
                {
                    textBox2.Text = "$ " + "0";
                }
                else
                {
                    textBox2.Text = "$ " + tip.ToString("0.00");
                }

                //show calculated total per person

                textBox3.Text = "$ " + total.ToString("0.00");
            }else if (radioButton4.Checked == true)
            {
                if (tip == 0)
                {
                    textBox2.Text = "$ " + "0";
                }
                else
                {
                    textBox2.Text = "$ " + Math.Round(tip);
                }

                //show calculated total per person

                textBox3.Text = "$ " + Math.Round(total);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            Application.Exit();
        }
    }
}
