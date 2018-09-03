using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {        	
        float a;
        int count;
        bool viddod = true;
        Point dragStartPoint = new Point();
        public Form1()
        {
            InitializeComponent();
        }

        private void action (int co, string t)
        {
            if (textBox1.TextLength != 0)
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = co;
                label1.Text = a.ToString();
                label2.Text = t;
                viddod = true;
            }

        }

        private void action1(int co, string t)
        {
            if (textBox1.TextLength != 0)
            {
                count = co;
                label1.Text = textBox1.Text;
                label2.Text = t;
                viddod = true;
            }

        }

        private void calk()
        {
            if (label1.Text != "" & textBox1.TextLength != 0)
            {
                switch (count)
                {
                    case 1:
                        a = a + float.Parse(textBox1.Text);
                        textBox1.Text = a.ToString();
                        break;
                    case 2:
                        a = a - float.Parse(textBox1.Text);
                        textBox1.Text = a.ToString();
                        break;
                    case 3:
                        a = a / float.Parse(textBox1.Text);
                        textBox1.Text = a.ToString();
                        break;
                    case 4:
                        a = a * float.Parse(textBox1.Text);
                        textBox1.Text = a.ToString();
                        break;
                    case 5:
                        a = Convert.ToSingle(Math.Pow(Convert.ToSingle(Math.E), float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 6:
                        a = Convert.ToSingle(Math.Pow(float.Parse(textBox1.Text),2));
                        textBox1.Text = a.ToString();
                        break;
                    case 7:
                        a = Convert.ToSingle(Math.Pow(a, float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 8:
                        a = Convert.ToSingle(Math.Sqrt(float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 9:
                        a = Convert.ToSingle(Math.Sin(float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 10:
                        a = Convert.ToSingle(Math.Cos(float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 11:
                        a = Convert.ToSingle(Math.Tan(float.Parse(textBox1.Text)));
                        textBox1.Text = a.ToString();
                        break;
                    case 12:
                        a = Convert.ToSingle(Math.Pow(float.Parse(textBox1.Text), 1/a));
                        textBox1.Text = a.ToString();
                        break;

                    default:
                        break;
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                if (textBox1.TextLength != 0)
                {
                    textBox1.Text = textBox1.Text + ",";
                }
                else textBox1.Text = "0,";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            //    e.Handled = false;
            //else
                e.Handled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(1, "+");
            }
            else action(1, "+");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(2, "-");
            }
            else action(2, "-");
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(3, "/");
            }
            else action(3, "/");
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(4, "*");
            }
            else action(4, "*");
           
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(5, "e^x");
                calk();
            }
            else
            {
                action1(5, "e^x");
                calk();
            }
               
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(6, "x^2");
                calk();
            }
            else
            {
                action1(6, "x^2");
                calk();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(7, "x^y");
            }
            else action(7, "x^y");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(8, "sqrt");
                calk();
            }
            else
            {
                action1(8, "sqrt");
                calk();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(9, "sin");
                calk();
            }
            else
            {
                action1(9, "sin");
                calk();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(10, "cos");
                calk();
            }
            else
            {
                action1(10, "cos");
                calk();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action1(11, "tan");
                calk();
            }
            else
            {
                action1(11, "tan");
                calk();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calk();
                action(12, "sqrt y");
            }
            else action(12, "sqrt y");
        }
 private void button16_Click(object sender, EventArgs e)
        {
                calk();
                label1.Text = "";
                label2.Text = "";
            
        }


        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            label1.Text = "";
            label2.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPoint = new Point(e.X + (Width - ClientSize.Width) / 2, e.Y - (Width - ClientSize.Width) / 2);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point location = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(location.X - dragStartPoint.X, location.Y - dragStartPoint.Y - (Height - ClientSize.Height));
            }
        }

    }
}
