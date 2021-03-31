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
        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxRed_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxGreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxBlue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMixColor_Click(object sender, EventArgs e)
        {
            int Red;
            Red = Convert.ToInt32(txtBoxRed.Text);

            int Green;
            Green = Convert.ToInt32(txtBoxGreen.Text);

            int Blue;
            Blue = Convert.ToInt32(txtBoxBlue.Text);

            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }
    }
}
