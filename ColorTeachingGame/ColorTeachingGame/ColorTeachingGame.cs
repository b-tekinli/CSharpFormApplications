using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorTeachingGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        // diziler oluşturuldu.
        string[] _colors = { "RED", "YELLOW", "PURPLE", "ORANGE", "PINK", "WHITE", "GRAY", "BLACK", "BLUE", "GREEN" };
        int[] colorId = new int[10];

        readonly Random random = new();

        private void Game_Load(object sender, EventArgs e)
        {
            Random _random = new Random();

            // rastgele renkler sıralanıp listbox'a eklendi.
            for (int i = 0; i < 10; i++)
            {
                colorId[i] = _random.Next(0, _colors.Length);

                for (int control = 0; control < i; control++)
                {
                    if (colorId[control] == colorId[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < _colors.Length; i++)
            {
                lstColors.Items.Add(_colors[colorId[i]]);
            }
        }


        // yeni renk sormak için metod oluşturuldu.
        public void NewColorAsk()
        {
            lblTime.Text = "10";

            int colorId = random.Next(0, 10);

            lblColor.Text = _colors[colorId] + " adlı rengi seçiniz!".ToUpper();
            lblColor.Tag = _colors[colorId];
        }


        // başlat butonu ayarlandı.
        private void btnStart_Click(object sender, EventArgs e)
        {
            ConfigureTimer(500, true);
            NewColorAsk();
        }


        // zamanın hızı ayarlandı.
        public void ConfigureTimer(int interval = 500, bool isEnabled = true)
        {
            timer.Interval = 800;
            timer.Enabled = true;
        }


        // doğru renk tıklansa dahil süre 0 olduğunda yeni renk sorduruldu ve paneller eklendi.
        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblTime.Text == "0")
            {
                NewColorAsk();
            }

            PanelAdd();
            PanelScroll();
            lblTime.Text = Convert.ToString(Convert.ToInt32(lblTime.Text) - 1);
        }


        // paneller kontrol edildi.
        private List<Panel> PanelControls(Control.ControlCollection controls)
        {
            var allPanelsControls = new List<Panel>();

            foreach (Control control in controls)
            {
                PanelControls(control.Controls);
                if (control.Tag == null) continue;
                if (control.Tag.ToString().Contains("colors"))
                    allPanelsControls.Add(control as Panel);
            }

            return allPanelsControls;
        }


        // panel eklemek için metod yazıldı.
        private void PanelAdd()
        {
            int color = random.Next(0, 10);

            var panel = new Panel
            {
                Width = 40,
                Height = 40,
                BackColor = Color.FromName(_colors[color]),
                Tag = "colors"
            };


            panel.MouseClick += Panel_MouseClick;
            var width = this.Size.Width;
            var x = random.Next(0, width);
            panel.Location = new Point(x, 5);
            this.Controls.Add(panel);
        }


        // panel kaydırma işlemi eklendi.
        public void PanelScroll()
        {
            var panels = PanelControls(this.Controls);

            foreach (var t in panels)
            {
                Point point = t.Location;
                t.Location = new Point(point.X, point.Y + 50);
            }
        }


        // panele tıklatıldığında gerçekleşecek olaylar ayarlandı.
        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            var panel = (Panel)sender;

            var wantColor = Color.FromName(lblColor.Tag.ToString());
            lblTime.Text = "10";


            // panel rengi istenen renge eşitse
            if (panel.BackColor == wantColor)
            {
                // label'da red istenildiğinde listbox'taki red'e eşit olma durumu ayarlandı.
                if (lblColor.Tag == "RED")
                {
                    // red rengi listbox'tan kaldırıldı.
                    lstColors.Items.Remove("RED");

                    // doğru renge tıklandığı için +1 puan eklendi.
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "YELLOW")
                {
                    lstColors.Items.Remove("YELLOW");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "PURPLE")
                {
                    lstColors.Items.Remove("PURPLE");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "ORANGE")
                {
                    lstColors.Items.Remove("ORANGE");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "PINK")
                {
                    lstColors.Items.Remove("PINK");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "GRAY")
                {
                    lstColors.Items.Remove("GRAY");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "WHITE")
                {
                    lstColors.Items.Remove("WHITE");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "BLACK")
                {
                    lstColors.Items.Remove("BLACK");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "BLUE")
                {
                    lstColors.Items.Remove("BLUE");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
                else if (lblColor.Tag == "GREEN")
                {
                    lstColors.Items.Remove("GREEN");
                    lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1);
                }
            }
            else
            {
                // yanlış renge tıklandığı için puan 1 eksiltildi.
                lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) - 1);
                // yeni renk sormak için ilgili metod çağırıldı.
                NewColorAsk();
            }
        }
    }
}
