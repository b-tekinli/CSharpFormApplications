using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Snake snake = new Snake();
        Direction direction1;
        PictureBox[] pbSnakeParts;
        bool anyFood = false;
        Random random = new Random();
        PictureBox pbFood;
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            snake = new Snake();
            direction1 = new Direction(-10, 0);
            pbSnakeParts = new PictureBox[0];

            for (int i = 0; i < 3; i++)                                 // yılanın parçalarının uzunluğu 3 olduğu için.
            {
                Array.Resize(ref pbSnakeParts, pbSnakeParts.Length + 1);
                pbSnakeParts[i] = pbAdd();
            }
            timer1.Start();
            btnRestart.Enabled = false;
        }

        private PictureBox pbAdd()
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Size = new Size(10, 10);
            pictureBox.BackColor = Color.White;
            pictureBox.Location = snake.GetPos(pbSnakeParts.Length - 1);
            panel1.Controls.Add(pictureBox);
            return pictureBox;
        }

        private void pbUpdate()
        {
            for (int i = 0; i < pbSnakeParts.Length; i++)
            {
                pbSnakeParts[i].Location = snake.GetPos(i);
            }
        }

        // Yön tuşları ayarlandı.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)       // yukarı ok tuşu ve W tuşuna basıldığında yukarı hareket etme ayarlandı.
            {
                if (direction1._y != 10)                           // yılanın kendiliğinden terse dönme durumu kontrol edildi.
                {
                    direction1 = new Direction(0, -10);
                }
                direction1 = new Direction(0, -10);
            }

            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (direction1._y != -10)
                {
                    direction1 = new Direction(0, -10);
                }
                direction1 = new Direction(0, 10);
            }

            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (direction1._x != 10)
                {
                    direction1 = new Direction(0, -10);
                }
                direction1 = new Direction(-10, 0);
            }

            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (direction1._x != -10)
                {
                    direction1 = new Direction(0, -10);
                }
                direction1 = new Direction(10, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Skor: " + score.ToString();
            snake.Go(direction1);
            pbUpdate();
            createFood();
            DidEatFood();
            HitItself();
            HitTheWall();
        }

        public void createFood()
        {
            if (!anyFood)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Red;
                pictureBox.Size = new Size(10, 10);
                pictureBox.Location = new Point(random.Next(panel1.Width / 10) * 10, random.Next(panel1.Height / 10) * 10);
                pbFood = pictureBox;
                anyFood = true;
                panel1.Controls.Add(pictureBox);
            }
        }

        public void DidEatFood()
        {
            if (snake.GetPos(0) == pbFood.Location)
            {
                score += 10;                                  // her yem yendiğinde skor 10 artırıldı.
                snake.Grow();                                 // yılan yeni yediğinde büyütüldü.
                Array.Resize(ref pbSnakeParts, pbSnakeParts.Length + 1);
                pbSnakeParts[pbSnakeParts.Length - 1] = pbAdd();
                anyFood = false;
                panel1.Controls.Remove(pbFood);
            }
        }

        public void HitItself()
        {
            for (int i = 1; i < snake.SnakeSize; i++)
            {
                if (snake.GetPos(0) == snake.GetPos(i))
                {
                    GameOver();
                }
            }
        }

        public void HitTheWall()
        {
            Point point = snake.GetPos(0);

            if (point.X < 0 || point.X > panel1.Width - 10 || point.Y < 0 || point.Y > panel1.Height - 10)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            timer1.Stop();
            MessageBox.Show("Game Over!");
            btnRestart.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NewGame();
        }
    }
}
