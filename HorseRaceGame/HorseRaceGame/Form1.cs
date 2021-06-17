using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
        }

        Random random = new Random();

        // başlat butonu ayarlandı.
        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rank = Convert.ToInt32(lblCounter.Text);
            rank++;
            lblCounter.Text = rank.ToString();                             // metre sayacı ayarlandı.

            int horse1Width = pcbHorse1.Width;                             // at genişlikleri ayarlandı.
            int horse2Width = pcbHorse2.Width;
            int horse3Width = pcbHorse3.Width;

            int finishDistance = lblFinishLine.Left;                       // bitiş uzaklığı sola ayarlandı ve finishDistance değişkenine atandı.

            pcbHorse1.Left = pcbHorse1.Left + random.Next(5, 15);          // atların random kazanması ayarlandı.
            pcbHorse2.Left = pcbHorse2.Left + random.Next(5, 15);
            pcbHorse3.Left = pcbHorse3.Left + random.Next(5, 15);
            

            // 1 numaralı atın kontrol durumu
            if (horse1Width + pcbHorse1.Left >= finishDistance && horse2Width + pcbHorse2.Left > horse3Width + pcbHorse3.Left)  // 1. atın bitiş çizgisinin soluna geldiğinde kazanması ayarlandı.
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;                                                                                   // yarış sonucu aktif edildi.
                lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n3 numaralı at 3. oldu!";           // kazanan at ekrana yazdırıldı.
            }
            else if (horse1Width + pcbHorse1.Left >= finishDistance && horse3Width + pcbHorse3.Left > horse2Width + pcbHorse2.Left)
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;
                lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n2 numaralı at 3. oldu!\n3 numaralı at 2. oldu!";
            }

            // 2 numaralı atın kontrol durumu
            else if (horse2Width + pcbHorse2.Left >= finishDistance && horse1Width + pcbHorse1.Left > horse3Width + pcbHorse3.Left)
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;
                lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n3 numaralı at 3. oldu!";
            }
            else if (horse2Width + pcbHorse2.Left >= finishDistance && horse3Width + pcbHorse3.Left > horse1Width + pcbHorse1.Left)
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;
                lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n1 numaralı at 3. oldu!";
            }

            // 3 numaralı atın kontrol durumu
            else if (horse3Width + pcbHorse3.Left >= finishDistance && horse1Width + pcbHorse1.Left > horse2Width + pcbHorse2.Left)
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;
                lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n2 numaralı at 3. oldu!";
            }
            else if (horse3Width + pcbHorse3.Left >= finishDistance && horse2Width + pcbHorse2.Left > horse1Width + pcbHorse1.Left)
            {
                timer1.Enabled = false;
                lblRaceResult.Visible = true;
                lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n1 numaralı at 3. oldu!";
            }


            if (pcbHorse1.Left > pcbHorse3.Left + 5 && pcbHorse1.Left > pcbHorse2.Left + 1)     // atın öne geçme durumu şart ile belirtildi.
            {
                lblRaceStatus.Text = "1 numaralı at öne geçti!";                                // durum ekrana yazdırıldı.
            }
            else if (pcbHorse2.Left > pcbHorse1.Left + 5 && pcbHorse2.Left > pcbHorse3.Left + 1)
            {
                lblRaceStatus.Text = "2 numaralı at öne geçti!";
            }
            else if (pcbHorse3.Left > pcbHorse1.Left + 5 && pcbHorse3.Left > pcbHorse2.Left + 1)
            {
                lblRaceStatus.Text = "3 numaralı at öne geçti!";
            }
        }

        // restart butonu ayarlandı.
        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    lblRaceStatus.Text = "Yarış Başlıyor!";
                    lblRaceResult.Text = "Yarışma Sonucu";
                    lblMetre.Text = "METRE";
                }
            }

            timer1.Enabled = false;
            pcbHorse1.Left = 0;                                    // oyun sıfırlandığında atların en sola geçmesi sağlandı.
            pcbHorse3.Left = 0;
            pcbHorse2.Left = 0;
            lblFinishLine.Text = " ";
            lblCounter.Text = Convert.ToString(0);                // oyun sıfırlandığında metre sayacının 0 olması sağlandı.
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // form1'in içinde tanımlanması için
        }
    }
}

