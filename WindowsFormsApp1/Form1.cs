using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Numerics;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num;
        string operation;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "0";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            textBox1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = null;
            }
            textBox1.Text += "7";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //multipling
            num = Convert.ToDouble(textBox1.Text); 
            textBox1.Text = null;
            operation = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //equal
            double num2 = Convert.ToDouble(textBox1.Text);
            double result;
            
            if (operation == "*")
            {
                result = num2 * num;
                textBox1.Text = result.ToString();
            }
            if (operation == "-")
            {
                result = num - num2;
                textBox1.Text = result.ToString();
            }
            if (operation == "+")
            {
                result = num + num2;
                textBox1.Text = result.ToString();
            }
            if (operation == "/")
            {
                result = num / num2;
                textBox1.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text) * (-1);
            textBox1.Text = num.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //-
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //add
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "+";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "/"; //girsin orxana 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double d = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = d.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double d = Math.Pow(Convert.ToDouble(textBox1.Text), 2);
            textBox1.Text = d.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double c = 1/(Convert.ToDouble(textBox1.Text));
            textBox1.Text = c.ToString();
        }
        
        
        private void button24_Click(object sender, EventArgs e)
        {
            int abc = Convert.ToInt16(textBox1.Text);
            BigInteger nem;

            nem = 1;
            for (int i = 1; i <= abc; i++)
            {
                nem = BigInteger.Multiply(nem, i);
                textBox1.Text = nem.ToString("0.#######E+0");
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log10(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {

            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sinh(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cosh(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tanh(Convert.ToDouble(textBox1.Text)).ToString();
        }
    }
}
