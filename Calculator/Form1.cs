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
        double Memtokeep;         //to keep number in memory
        string Lastoperation;    //to keep four operation("+" "_" "*" "/") in memory
        string whatPressed;
        public Form1()
        {
            InitializeComponent();
        }
        //initializing number 0 until 9 in caculator
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" )   //if there is 0 in textbox it's needed to clear "0"
                {
                TextBox1.Text = "";
                }
            whatPressed = whatPressed + "1";
            TextBox1.Text = whatPressed;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "2";
            TextBox1.Text = whatPressed;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "3";
            TextBox1.Text = whatPressed;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "4";
            TextBox1.Text = whatPressed;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "5";
            TextBox1.Text = whatPressed;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "6";
            TextBox1.Text = whatPressed;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "7";
            TextBox1.Text = whatPressed;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "8";
            TextBox1.Text = whatPressed;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "9";
            TextBox1.Text = whatPressed;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            whatPressed = whatPressed + "0";
            TextBox1.Text = whatPressed;
        }
        //clear textbox for new operating
        private void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            whatPressed = "";
            Memtokeep = 0;
        }
        //defining "+" in calculator
        private void Button15_Click(object sender, EventArgs e)
        {
            if (Lastoperation != "")
            {
                Calculate();
                whatPressed = "";
                Lastoperation = "+";
                TextBox1.Text = Convert.ToString(Memtokeep);
            }
            if (whatPressed != "")
            {
                Lastoperation = "+";
                Calculate();
                TextBox1.Text = Convert.ToString(Memtokeep);
                whatPressed = "";
            }           
        }
        //defining "-" in calculator
        private void Button14_Click(object sender, EventArgs e)
        {
            if (Lastoperation != "")
            {
                Calculate();
                whatPressed = "";
                Lastoperation = "-";
                TextBox1.Text = Convert.ToString(Memtokeep);
            }
            if (whatPressed != "")
            {
                Lastoperation = "-";
                Calculate();
                TextBox1.Text = Convert.ToString(Memtokeep);
                whatPressed = "";
            }
        }
        //defining "*" in calculator
        private void Button13_Click(object sender, EventArgs e)
        {
            if (Lastoperation != "")
            {
                Calculate();
                whatPressed = "";
                Lastoperation = "*";
                TextBox1.Text = Convert.ToString(Memtokeep);
            }
            if (whatPressed != "")
            {
                Lastoperation = "*";
                Calculate();
                TextBox1.Text = Convert.ToString(Memtokeep);
                whatPressed = "";
            }
        }
        //defining "/" in calculator
        private void Button16_Click(object sender, EventArgs e)
        {
            if (Lastoperation != "")
            {
                Calculate();
                whatPressed = "";
                Lastoperation = "/";
                TextBox1.Text = Convert.ToString(Memtokeep);
            }
            if (whatPressed != "")
            {
                Lastoperation = "/";
                Calculate();
                TextBox1.Text = Convert.ToString(Memtokeep);
                whatPressed = "";
            }
        }
        //defining "=" in calculator
        private void Button11_Click(object sender, EventArgs e)
        {
            Calculate();
            TextBox1.Text = Convert.ToString(Memtokeep);
            whatPressed = "";
        }
        //function for calculating
        private void Calculate()
        {
            if (whatPressed != "")
            {
                if (Lastoperation == "+")
                {
                    Memtokeep = Memtokeep + Convert.ToDouble(whatPressed);                
                }
                else if (Lastoperation == "-")
                {
                    Memtokeep = Memtokeep - Convert.ToDouble(whatPressed);
                }
                else if (Lastoperation == "*")
                {
                    Memtokeep = Memtokeep * Convert.ToDouble(whatPressed);
                }
                else if (Lastoperation == "/")
                {
                    Memtokeep = Memtokeep / Convert.ToDouble(whatPressed);
                }
            }
            if (Memtokeep == 0)
            {
                Memtokeep = Convert.ToDouble(whatPressed);
             }
            return;
        }
    }
}
