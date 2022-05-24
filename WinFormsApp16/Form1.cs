namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        char ope;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        
        
        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null || label1.Text == "Cannot divide by zero")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(label1.Text);

            label1.Text = "0";
            ope = '+';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(label1.Text);

            label1.Text = "0";
            ope = '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(label1.Text);

            label1.Text = "0";
            ope = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(label1.Text);

            label1.Text = "0";
            ope = '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(label1.Text);

            if (ope == '+')
            {
                result = (num1 + num2);
                label1.Text = Convert.ToString(result);
                num1 = result;
            }

            if (ope == '-')
            {
                result = (num1 - num2);
                label1.Text = Convert.ToString(result);
                num1 = result;
            }

            if (ope == '*')
            {
                result = (num1 * num2);
                label1.Text = Convert.ToString(result);
                num1 = result;
            }

            if (ope == '/')
            {
                if (num2 == 0)
                {
                    label1.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (num1 / num2);
                    label1.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
        }
    }
}