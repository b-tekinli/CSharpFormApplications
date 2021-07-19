using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            carSpeed = 5;
            otherCarSpeed = 5;
            points = 0;

            // coordinate - my car
            pcbCar3.Left = 160;
            pcbCar3.Top = 300;


            // initial coordinates of other cars
            pcbCar1.Left = 30;
            pcbCar1.Top = 50;

            pcbCar2.Left = 320;
            pcbCar2.Top = 50;


            leftDirection = false;
            rightDirection = false;

            timer1.Start();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
