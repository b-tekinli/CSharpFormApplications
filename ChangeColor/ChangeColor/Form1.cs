using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColor
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void txtBoxRed_TextChanged(object sender, EventArgs e)
        {
            txtBoxRed.Text = "Red";
            string red = txtBoxRed.Text;
            txtBoxRed.BackColor = Color.Red;
            
        }
    }
}
