using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTeachingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectColor();
            timer1.Enabled = true;
        }

        public void SelectColor()
        {

            int random;
            int[] colors = new int[10];

            Random r = new Random();

            random = r.Next(0, 10);

            foreach (var item in colors)
            {
                int result = String.Compare(item.ToString(), colors.ToString());        // result değişkeninde compare metodu ile karşılaştırma yaptık.

                if (result == item)                                                    // result değişkeninin 0'a eşit olması durumunu kontrol ettik.
                {
                    
                }
            }

            if (random == 0)
            {
                lblColor.Text = "RED";
            }
            else if (random == 1)
            {
                lblColor.Text = "WHITE";
            }
            else if (random == 2)
            {
                lblColor.Text = "GREEN";
            }
            else if (random == 3)
            {
                lblColor.Text = "PURPLE";
            }
            else if (random == 4)
            {
                lblColor.Text = "GRAY";
            }
            else if (random == 5)
            {
                lblColor.Text = "YELLOW";
            }
            else if (random == 6)
            {
                lblColor.Text = "BLACK";
            }
            else if (random == 7)
            {
                lblColor.Text = "ORANGE";
            }
            else if (random == 8)
            {
                lblColor.Text = "PINK";
            }
            else if (random == 9)
            {
                lblColor.Text = "BLUE";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBarScore.Value--;
            lblCounter.Text = pBarScore.Value.ToString();

            if (lblCounter.Text == "0")
            {
                timer1.Enabled = false;
                btnRed.Enabled = false;
                btnYellow.Enabled = false;
                btnWhite.Enabled = false;
                btnBlack.Enabled = false;
                btnGreen.Enabled = false;
                btnOrange.Enabled = false;
                btnPurple.Enabled = false;
                btnPink.Enabled = false;
                btnGray.Enabled = false;
                btnBlue.Enabled = false;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "RED")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "WHITE")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "GREEN")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "PURPLE")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "GRAY")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "YELLOW")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "BLACK")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "ORANGE")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "PINK")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (lblColor.Text == "BLUE")
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) + 1).ToString();
                SelectColor();
            }
            else
            {
                lblScoreCounter.Text = (Convert.ToInt16(lblScoreCounter.Text) - 1).ToString();
                SelectColor();
            }
        }
    }
}
