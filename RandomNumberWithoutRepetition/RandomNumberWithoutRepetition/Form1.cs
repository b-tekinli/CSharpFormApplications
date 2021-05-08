using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberWithoutRepetition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(txtBoxStart.Text);
            int finish = Convert.ToInt32(txtBoxFinish.Text);
            int blockNum = Convert.ToInt32(txtBoxBlockNum.Text);


            int[] arrayList = new int[blockNum];
            Random random = new Random();
            

            lstBoxRan.Items.Clear();


            for (int i = 0; i < arrayList.Length; i++)
            {
                int numbers = random.Next(start, finish);
                int counter = 0;

                if (i == 0)
                {
                    arrayList[i] = numbers;
                }
                else
                {
                    foreach (var item in lstBoxRan.Items)
                    {
                        int result = String.Compare(item.ToString(), numbers.ToString());

                        if (result == 0)
                        {
                            counter = -1;
                        }
                    }
                    if (counter == 0 && numbers != blockNum)
                    {
                        lstBoxRan.Items.Add(numbers.ToString());
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }
        }
    }
}
