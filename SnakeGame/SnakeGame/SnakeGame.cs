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


        // gerekli değişkenler ve nesneler oluşturuldu.
        Snake snake;
        Direction direction1;
        PictureBox[] pbSnakeParts;
        bool anyFood = false;
        Random random = new Random();
        PictureBox pbFood;
        int score = 0;


        private void SnakeGame_Load(object sender, EventArgs e)
        {
            timer.Stop();                                                   // oyun açıldığında oyunun başlamaması kontrol edildi.
        }


        // yeni oyunun başlaması için fonksiyon tanımlandı.
        private void NewGame()
        {
            anyFood = false;                                                // yem var mı yok mu diye kontrol edildi.
            score = 0;
            snake = new Snake(panel.Size);
            direction1 = new Direction(-10, 0);
            pbSnakeParts = new PictureBox[0];


            for (int i = 0; i < 3; i++)                                     // yılanın parçalarının uzunluğu 3 olduğu için 3'e kadar döndürüldü.
            {
                Array.Resize(ref pbSnakeParts, pbSnakeParts.Length + 1);
                pbSnakeParts[i] = PbAdd();
            }

            
            // oyun başladığı anda ekranda aktif ve devre dışı bırakılacak özellikler ayarlandı.
            btnRestart.Enabled = false;
            timer.Start();
            cboChangeColor.Enabled = false;
            btnStart.Enabled = false;
        }


        // oyun başladığında panele eklenecek nesneler için fonksiyon tanımlandı.
        private PictureBox PbAdd()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(10, 10);                             // yılan büyüklüğü belirtildi.
            pictureBox.Location = snake.GetPos(pbSnakeParts.Length - 1);
            panel.Controls.Add(pictureBox);


            if (cboChangeColor.Text == "Kırmızı")                           // combobox'taki yılan rengi seçimine göre renkler belirtildi.
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


        // yılanın oyun durumundaki konumunun güncellenmesi için metod yazıldı.
        private void PbUpdate()
        {
            for (int i = 0; i < pbSnakeParts.Length; i++)
            {
                pbSnakeParts[i].Location = snake.GetPos(i);
            }
        }


        // yön tuşları ayarlandı.
        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
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
        }


        // yem oluşturmak için metod yazıldı.
        public void CreateFood()
        {
            if (!anyFood)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Red;                          // yem rengi kırmızı olarak ayarlandı.
                pictureBox.Size = new Size(10, 10);                        // yem büyüklüğü ayarlandı.
                pictureBox.Location = new Point(random.Next(panel.Width / 10) * 10, random.Next(panel.Height / 10) * 10);
                pbFood = pictureBox;
                anyFood = true;
                panel.Controls.Add(pictureBox);
            }
        }


        // yemi yiyip yemediğini kontrol eden metod yazıldı.
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


        // yenilgi fonksiyonu yazıldı.
        public void GameOver()
        {
            timer.Stop();
            MessageBox.Show("Game Over!");
            btnRestart.Enabled = true;
            cboChangeColor.Enabled = true;
        }


        // yeniden başlat butonu
        private void btnRestart_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            NewGame();
        }


        // başlat butonu
        private void btnStart_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
