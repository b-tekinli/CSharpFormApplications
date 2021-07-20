using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int points = 0;
        int roadSpeed = 5;
        int carSpeed = 5;

        bool leftDirection = false;
        bool rightDirection = false;

        int otherCarSpeed = 5;

        Random random = new Random();


        public void startGame()
        {
            btnStart.Enabled = false;
            pcbBoom.Visible = false;

            lblHighScore.Text = Settings1.Default.highScore.ToString();

            carSpeed = 5;
            otherCarSpeed = 5;
            points = 0;

            // coordinate - my car
            pcbMyCar.Left = 160;
            pcbMyCar.Top = 300;


            // initial coordinates of other cars
            pcbCar1.Left = 30;
            pcbCar1.Top = 50;

            pcbCar2.Left = 320;
            pcbCar2.Top = 300;


            leftDirection = false;
            rightDirection = false;


            pcbBoom.Left = 165;
            pcbBoom.Top = 294;

            timer1.Start();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
            turnUpSound();
        }

        private void turnUpSound()
        {
            SoundPlayer sound = new SoundPlayer();
            string noSound = Application.StartupPath + "\\lostsky.wav";
            sound.SoundLocation = noSound;
            sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            points++;
            lblScore.Text = points.ToString();

            pcbRoad.Top += roadSpeed;

            if (pcbRoad.Top > 400)
            {
                pcbRoad.Top = -100;
            }
            
            if (leftDirection)
            {
                pcbMyCar.Left -= carSpeed;
            }

            if (rightDirection)
            {
                pcbMyCar.Left += carSpeed;
            }

            if (pcbMyCar.Left < 1)
            {
                leftDirection = false;
            }
            else if (pcbMyCar.Left + pcbMyCar.Width > 510)
            {
                rightDirection = false;
            }


            pcbCar1.Top += carSpeed;
            pcbCar2.Top += carSpeed;


            if (pcbCar1.Top > panel1.Height)
            {
                changeCar1();
                pcbCar1.Left = random.Next(20, 50);
                pcbCar1.Top = random.Next(40, 140) * -1;
            }

            if (pcbCar2.Top > panel1.Height)
            {
                changeCar2();
                pcbCar2.Left = random.Next(20, 50);
                pcbCar2.Top = random.Next(40, 140) * -1;
            }

            if (pcbMyCar.Bounds.IntersectsWith(pcbCar1.Bounds) || pcbMyCar.Bounds.IntersectsWith(pcbCar2.Bounds))
            {
                finishGame();
            }
        }


        private void changeCar1()
        {
            int queue = random.Next(1, 7);

            switch (queue)
            {
                case 1:
                    pcbCar1.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pcbCar1.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pcbCar1.Image = Properties.Resources.car3;
                    break;
                case 4:
                    pcbCar1.Image = Properties.Resources.car4;
                    break;
                case 5:
                    pcbCar1.Image = Properties.Resources.car5;
                    break;
                case 6:
                    pcbCar1.Image = Properties.Resources.car6;
                    break;
                case 7:
                    pcbCar1.Image = Properties.Resources.car7;
                    break;
                default:
                    break;
            }
        }

        private void changeCar2()
        {
            int queue = random.Next(1, 7);

            switch (queue)
            {
                case 1:
                    pcbCar2.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pcbCar2.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pcbCar2.Image = Properties.Resources.car3;
                    break;
                case 4:
                    pcbCar2.Image = Properties.Resources.car4;
                    break;
                case 5:
                    pcbCar2.Image = Properties.Resources.car5;
                    break;
                case 6:
                    pcbCar2.Image = Properties.Resources.car6;
                    break;
                case 7:
                    pcbCar2.Image = Properties.Resources.car7;
                    break;
                default:
                    break;
            }
        }

        private void finishGame()
        {
            timer1.Stop();

            if (Convert.ToInt32(lblScore.Text) > Convert.ToInt32(Settings1.Default.highScore.ToString()))
            {
                Settings1.Default.highScore = lblScore.Text;
            }

            btnStart.Enabled = true;
            pcbBoom.Visible = true;
            pcbMyCar.Controls.Add(pcbBoom);
            pcbBoom.Location = new Point(7, -5);
            pcbBoom.BringToFront();
            pcbBoom.BackColor = Color.Transparent;
            MessageBox.Show("Tebrikler! Skorunuz: " + lblScore.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && pcbMyCar.Left > 0)
            {
                leftDirection = true;
            }

            if (e.KeyCode == Keys.Right && pcbMyCar.Left + pcbMyCar.Width < panel1.Width)
            {
                rightDirection = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                leftDirection = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightDirection = false;
            }
        }
    }
}
