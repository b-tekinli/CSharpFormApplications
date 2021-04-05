using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int TrueNumber = 0;
            int FalseNumber = 0;
            int point = 0;


            if (rdBtnC1.Checked)
            {
                TrueNumber += 1;
            }
            if (rdBtnD2.Checked)
            {
                TrueNumber += 1;
            }
            if (rdBtnA3.Checked)
            {
                TrueNumber += 1;
            }
            if (rdBtnB4.Checked)
            {
                TrueNumber += 1;
            }

            FalseNumber = 4 - TrueNumber;
            point = TrueNumber * 25;


            MessageBox.Show("Puanınız: " + point);


            totalTrueNumber.Text = TrueNumber.ToString();
            totalFalseNumber.Text = FalseNumber.ToString();

        }
    }
}
