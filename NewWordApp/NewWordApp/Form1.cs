using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;
        }
        int counter = 0;

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter != lstBoxWords.Items.Count)
            {
                lblWords.Text = lstBoxWords.Items[counter].ToString();
                counter++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int select = lstBoxWords.SelectedIndex;
            if (select != -1)
            {
                lstBoxWords.Items.RemoveAt(select);
            }
            else
            {
                MessageBox.Show("Lütfen bir kelime seçiniz: ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstBoxWords.Items.Contains(txtBoxAdd.Text))
            {
                MessageBox.Show("Bu kelime zaten mevcut!");
            }
            else
            {
                lstBoxWords.Items.Add(txtBoxAdd.Text);
                int count = lstBoxWords.Items.Count - 1;
                txtBoxAdd.Text = "";
            }
        }
    }
}
