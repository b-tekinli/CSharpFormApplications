using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrtHesaplama_Click(object sender, EventArgs e)
        {
            double average = (Convert.ToDouble(txtNot1.Text) + Convert.ToDouble(txtNot2.Text)) / 2;
            lblOrtSonuc.Text = average.ToString();
        }
    }
}
