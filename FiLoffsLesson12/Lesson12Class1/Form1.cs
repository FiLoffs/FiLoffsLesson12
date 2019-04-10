using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson12Class1
{

    public partial class Form1 : Form
    {
        delegate int IntOperation(int i, int j);
        IntOperation op1;
        IntOperation op2;
        IntOperation op3;
        IntOperation op4;

        public Form1()
        {
            InitializeComponent();
            op1 = Form1.Sum;
            op2 = Form1.Min;
            op3 = Form1.Mul;
            op4 = Form1.Div;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntOperation res = new IntOperation(Start);

            if (checkBox1.Checked)
            {
                res += op1;
                //textBox1.Text = res.ToString();
                //label1.Text = res(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
            }

            if (checkBox2.Checked)
            {
                res += op2;
                //textBox1.Text = res.ToString();
            }

            if (checkBox3.Checked)
            {
                res += op3;
                //textBox1.Text = res.ToString();
            }

            if (checkBox4.Checked)
            {
                res += op4;
                //textBox1.Text = res.ToString();
            }

            label1.Text = res(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
            //label1.Text = Convert.ToString(res);

        }


        // Организуем ряд методов
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Min(int x, int y)
        {
            return x - y;
        }

        static int Mul(int x, int y)
        {
            return x * y;
        }

        static int Div(int x, int y)
        {
            return x / y;
        }
     
        static int Start(int a, int b )
        {
            return 0;
        }
    }
}
