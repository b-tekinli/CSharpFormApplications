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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }




        //string[] colors = { "White", "Red", "Yellow", "Green", "Orange", "Black", "Blue", "Pink", "Gray", "Purple" };

        Color[] colors = new Color[10];
        Random random = new Random();


        private void Game_Load(object sender, EventArgs e)
        {
            colors[0] = Color.White;
            colors[1] = Color.Red;
            colors[2] = Color.Yellow;
            colors[3] = Color.Green;
            colors[4] = Color.Orange;
            colors[5] = Color.Black;
            colors[6] = Color.Blue;
            colors[7] = Color.Pink;
            colors[8] = Color.Gray;
            colors[9] = Color.Purple;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            newColorAsk();
            timer.Interval = 500;
            timer.Enabled = true;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblTime.Text == "0")
            {
                newColorAsk();
            }

            panelAdd();
            panelScroll();
            lblTime.Text = Convert.ToString(Convert.ToInt32(lblTime.Text) - 1);
        }


        private List<Panel> panelControls(Control.ControlCollection controls)
        {
            List<Panel> allPanelsControls = new List<Panel>();

            foreach (Control control in controls)
            {
                panelControls(control.Controls);
                if (control.Tag != null)
                {
                    if (control.Tag.ToString().Contains("colors"))
                        allPanelsControls.Add(control as Panel);
                }
            }

            return allPanelsControls;
        }


        private void panelAdd()
        {
            int color = random.Next(0, 10);


            Panel panel = new Panel();
            panel.Width = 40;
            panel.Height = 40;
            panel.BackColor = colors[color];
            panel.Tag = "colors";
            panel.MouseClick += Panel_MouseClick;
            int width = this.Size.Width;
            int x = random.Next(0, width);
            panel.Location = new Point(x, 5);
            this.Controls.Add(panel);
        }


        public void newColorAsk()
        {
            lblTime.Text = "10";
            int colorID = random.Next(0, 10);


            lblColor.Text = colors[colorID].Name + " adlı rengi seçiniz!".ToUpper();
            lblColor.Tag = colors[colorID];
        }


        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;

            Color wantColor = (Color)lblColor.Tag;

            if (panel.BackColor == wantColor)
            {
                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                newColorAsk();
            }
            else
            {
                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) - 1);
                newColorAsk();
            }
        }


        public void panelScroll()
        {
            List<Panel> panels = panelControls(this.Controls);

            for (int i = 0; i < panels.Count; i++)
            {
                Point point = panels[i].Location;
                panels[i].Location = new Point(point.X, point.Y + 50);
            }
        }
    }
}
