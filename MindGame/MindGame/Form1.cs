using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindGame
{
    public partial class Form1 : Form
    {
        public string num1;
        public string num2;
        public string num3;
        public string num4;
        public string num5;
        public string num6;
        public string num7;
        public string num8;
        public string num9;
        public string num10;

        public Form1()
        {
            InitializeComponent();

            randomNumber();

            txtBox2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void randomNumber()
        {
            Random random = new Random();

            int b = 0;

            string num = "";

            for (int a = 1; a <= 10; a++)
            {
                b = random.Next(0, 10);

                num = num + b.ToString();

                if (a == 1) { num1 = num; }
                if (a == 2) { num2 = num; }
                if (a == 3) { num3 = num; }
                if (a == 4) { num4 = num; }
                if (a == 5) { num5 = num; }
                if (a == 6) { num6 = num; }
                if (a == 7) { num7 = num; }
                if (a == 8) { num8 = num; }
                if (a == 9) { num9 = num; }
                if (a == 10) { num10 = num; }
            }

            label1.Text = num;
            txtBox2.Text = label1.Text.Substring(0, 1);
            label1.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (txtBox1.Text == num1) { flag = 1; txtBox2.Text = num2.Substring(1, 1); }
            if (txtBox1.Text == num2) { flag = 1; txtBox2.Text = num3.Substring(2, 1); }
            if (txtBox1.Text == num3) { flag = 1; txtBox2.Text = num4.Substring(3, 1); }
            if (txtBox1.Text == num4) { flag = 1; txtBox2.Text = num5.Substring(4, 1); }
            if (txtBox1.Text == num5) { flag = 1; txtBox2.Text = num6.Substring(5, 1); }
            if (txtBox1.Text == num6) { flag = 1; txtBox2.Text = num7.Substring(6, 1); }
            if (txtBox1.Text == num7) { flag = 1; txtBox2.Text = num8.Substring(7, 1); }
            if (txtBox1.Text == num8) { flag = 1; txtBox2.Text = num9.Substring(8, 1); }
            if (txtBox1.Text == num9) { flag = 1; txtBox2.Text = num10.Substring(9, 1); }
            if (txtBox1.Text == num10) { flag = 1; txtBox2.Text = ("Tebrikler hafızanız çok güçlü :)"); }

            txtBox1.Text = "";

            if (flag == 0) { Application.Exit(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            txtBox1.Text = "";
            timer1.Enabled = false;
        }
    }
}
