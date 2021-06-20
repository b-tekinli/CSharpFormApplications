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
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
        }


        Snake snake;
        Direction direction1;
        PictureBox[] pbSnakeParts;
        bool anyFood = false;
        Random random = new Random();
        PictureBox pbFood;
        int score = 0;


        private void SnakeGame_Load(object sender, EventArgs e)
        {
            timer.Stop();
        }


        private void NewGame()
        {
            anyFood = false;
            score = 0;
            snake = new Snake();
            direction1 = new Direction(-10, 0);
            pbSnakeParts = new PictureBox[0];


            for (int i = 0; i < 3; i++)                                     // yılanın parçalarının uzunluğu 3 olduğu için.
            {
                Array.Resize(ref pbSnakeParts, pbSnakeParts.Length + 1);
                pbSnakeParts[i] = PbAdd();
            }


            btnRestart.Enabled = false;
            timer.Start();
            cboChangeColor.Enabled = false;
            btnStart.Enabled = false;
        }


        private PictureBox PbAdd()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(10, 10);
            pictureBox.Location = snake.GetPos(pbSnakeParts.Length - 1);
            panel.Controls.Add(pictureBox);


            if (cboChangeColor.Text == "Kırmızı")                           // combobox seçimine göre renkler belirtildi.
            {
                pictureBox.BackColor = Color.Red;
            }
            else if (cboChangeColor.Text == "Sarı")
            {
                pictureBox.BackColor = Color.Yellow;
            }
            else if (cboChangeColor.Text == "AçıkYeşil")
            {
                pictureBox.BackColor = Color.Lime;
            }
            else if (cboChangeColor.Text == "Turuncu")
            {
                pictureBox.BackColor = Color.Orange;
            }
            else if (cboChangeColor.Text == "Mor")
            {
                pictureBox.BackColor = Color.Purple;
            }
            else if (cboChangeColor.Text == "AçıkMavi")
            {
                pictureBox.BackColor = Color.Cyan;
            }
            else if (cboChangeColor.Text == "KoyuYeşil")
            {
                pictureBox.BackColor = Color.DarkGreen;
            }
            else if (cboChangeColor.Text == "KoyuMavi")
            {
                pictureBox.BackColor = Color.Blue;
            }
            else if (cboChangeColor.Text == "Pembe")
            {
                pictureBox.BackColor = Color.Pink;
            }
            else
            {
                pictureBox.BackColor = Color.White;                         // yılan rengi seçilmediğinde default rengin beyaz gelmesi sağlandı.
            }


            return pictureBox;
        }


        private void PbUpdate()
        {
            for (int i = 0; i < pbSnakeParts.Length; i++)
            {
                pbSnakeParts[i].Location = snake.GetPos(i);
            }
        }


        // Yön tuşları ayarlandı.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)                // yukarı ok tuşu ve W tuşuna basıldığında yukarı hareket etme ayarlandı.
            {
                if (direction1._y != 10)                                    // yılanın kendiliğinden terse dönme durumu kontrol edildi.
                {
                    direction1 = new Direction(0, -10);
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (direction1._y != -10)
                {
                    direction1 = new Direction(0, 10);
                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (direction1._x != 10)
                {
                    direction1 = new Direction(-10, 0);
                }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (direction1._x != -10)
                {
                    direction1 = new Direction(10, 0);
                }
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Skor: " + score.ToString();                    // skor ekrana yazdırıldı.
            snake.Go(direction1);                                           // yılanın ilerlemesi için yön belirtildi.


            // fonksiyonlar çağırıldı.
            PbUpdate();
            CreateFood();
            DidEatFood();
            HitItself();

            // duvara çarpma özelliğini aktif etmek için bu fonksiyonu yorum satırı olmaktan çıkartmalısınız.
            HitTheWall();
        }


        public void CreateFood()
        {
            if (!anyFood)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.White;                         // yem rengi beyaz olarak ayarlandı.
                pictureBox.Size = new Size(10, 10);                         // yem büyüklüğü ayarlandı.
                pictureBox.Location = new Point(random.Next(panel.Width / 10) * 10, random.Next(panel.Height / 10) * 10);
                pbFood = pictureBox;
                anyFood = true;
                panel.Controls.Add(pictureBox);
            }
        }


        public void DidEatFood()
        {
            if (snake.GetPos(0) == pbFood.Location)
            {
                score += 10;                                                // her yem yendiğinde skor 10 artırıldı.
                snake.Grow();                                               // yılan yemi yediğinde büyütüldü.
                Array.Resize(ref pbSnakeParts, pbSnakeParts.Length + 1);
                pbSnakeParts[pbSnakeParts.Length - 1] = PbAdd();
                anyFood = false;
                panel.Controls.Remove(pbFood);
            }
        }


        // yılanın kendine çarpma fonksiyonu yazıldı.
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


        // yılanın duvara çarpma fonksiyonu yazıldı.        NOT: Bu fonksiyonu aktif etmek için timer'ın içinde yorum satırı olmaktan çıkartmalısınız.
        public void HitTheWall()
        {
            Point point = snake.GetPos(0);

            if (point.X < 0 || point.X > panel.Width - 10 || point.Y < 0 || point.Y > panel.Height - 10)
            {
                GameOver();
            }
        }


        // yenilgi fonksiyonu yazıldı.
        public void GameOver()
        {
            timer.Stop();
            MessageBox.Show("Game Over!");
            btnRestart.Enabled = true;
            cboChangeColor.Enabled = true;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            NewGame();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
