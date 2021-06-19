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
    public partial class HorceRaceGame : Form
    {
        public HorceRaceGame()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
        }


        Random random = new Random();


        private void timer_Tick(object sender, EventArgs e)
        {
            // label içinde gösterdiğimiz sayaç integer'a dönüştürüldü.
            int rank = Convert.ToInt32(lblCounter.Text);


            // derece 1 artırıldı.
            rank++;


            // metre sayacı ayarlandı.
            lblCounter.Text = rank.ToString();


            // at genişlikleri ayarlandı.
            int horse1Width = pcbHorse1.Width;
            int horse2Width = pcbHorse2.Width;
            int horse3Width = pcbHorse3.Width;
            int horse4Width = pcbHorse4.Width;


            // bitiş uzaklığı sola ayarlandı ve finishDistance değişkenine atandı.
            int finishDistance = lblFinishLine.Left;


            // atların random kazanması ayarlandı.
            pcbHorse1.Left = pcbHorse1.Left + random.Next(5, 15);
            pcbHorse2.Left = pcbHorse2.Left + random.Next(5, 15);
            pcbHorse3.Left = pcbHorse3.Left + random.Next(5, 15);
            pcbHorse4.Left = pcbHorse4.Left + random.Next(5, 15);


            // genişlik ve sol kenar toplanıp değişkene atıldı.
            int horse1 = horse1Width + pcbHorse1.Left;
            int horse2 = horse2Width + pcbHorse2.Left;
            int horse3 = horse3Width + pcbHorse3.Left;
            int horse4 = horse4Width + pcbHorse4.Left;



            // atların bitiş çizgisine geldiğinde kazanması ayarlandı.
            if (horse1 > finishDistance && horse2 > finishDistance && horse3 > finishDistance && horse4 > finishDistance)
            {

                // oyun durduruldu.
                timer.Enabled = false;


                // 1 numaralı atın kontrol durumu ve kazanma dereceleri ayarlandı.
                if ((horse1 > horse2) && (horse2 > horse3) && (horse3 > horse4))
                {
                    lblRaceResult.Visible = true;

                    // kazanan at ve diğerlerinin dereceleri ekrana yazdırıldı.
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse1 > horse2) && (horse2 > horse3) && (horse4 > horse3))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n3 numaralı at 4. oldu!";
                }
                else if ((horse1 > horse3) && (horse3 > horse2) && (horse2 > horse4))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n2 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse1 > horse3) && (horse3 > horse4) && (horse4 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }
                else if ((horse1 > horse3) && (horse3 > horse2) && (horse4 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }
                else if ((horse1 > horse4) && (horse4 > horse3) && (horse3 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "1 numaralı at yarışı kazandı!\n4 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }



                // 2 numaralı atın kontrol durumu ve kazanma dereceleri ayarlandı.
                if ((horse2 > horse1) && (horse1 > horse3) && (horse3 > horse4))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse2 > horse1) && (horse1 > horse4) && (horse4 > horse3))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n3 numaralı at 4. oldu!";
                }
                else if ((horse2 > horse3) && (horse3 > horse1) && (horse1 > horse4))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse2 > horse3) && (horse3 > horse4) && (horse4 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }
                else if ((horse2 > horse4) && (horse4 > horse1) && (horse1 > horse3))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n4 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n3 numaralı at 4. oldu!";
                }
                else if ((horse2 > horse4) && (horse4 > horse3) && (horse3 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "2 numaralı at yarışı kazandı!\n4 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }



                // 3 numaralı atın kontrol durumu ve kazanma dereceleri ayarlandı.
                if ((horse3 > horse4) && (horse4 > horse1) && (horse1 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n4 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }
                else if ((horse3 > horse4) && (horse4 > horse2) && (horse2 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n4 numaralı at 2. oldu!\n2 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }
                else if ((horse3 > horse2) && (horse2 > horse1) && (horse1 > horse4))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse3 > horse2) && (horse2 > horse4) && (horse4 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }
                else if ((horse3 > horse1) && (horse1 > horse2) && (horse1 > horse4))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n2 numaralı at 3. oldu!\n4 numaralı at 4. oldu!";
                }
                else if ((horse3 > horse1) && (horse1 > horse4) && (horse4 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "3 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n4 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }



                // 4 numaralı atın kontrol durumu ve kazanma dereceleri ayarlandı.
                if ((horse4 > horse3) && (horse3 > horse2) && (horse2 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n2 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }
                else if ((horse4 > horse3) && (horse3 > horse1) && (horse1 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n3 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }
                else if ((horse4 > horse2) && (horse2 > horse3) && (horse3 > horse1))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n1 numaralı at 4. oldu!";
                }
                else if ((horse4 > horse2) && (horse2 > horse1) && (horse1 > horse3))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n2 numaralı at 2. oldu!\n1 numaralı at 3. oldu!\n3 numaralı at 4. oldu!";
                }
                else if ((horse4 > horse1) && (horse1 > horse2) && (horse2 > horse3))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n2 numaralı at 3. oldu!\n3 numaralı at 4. oldu!";
                }
                else if ((horse4 > horse1) && (horse1 > horse3) && (horse3 > horse2))
                {
                    lblRaceResult.Visible = true;
                    lblRaceResult.Text = "4 numaralı at yarışı kazandı!\n1 numaralı at 2. oldu!\n3 numaralı at 3. oldu!\n2 numaralı at 4. oldu!";
                }
            }


            // atların öne geçme durumu şart ile belirtildi.
            if (pcbHorse1.Left > pcbHorse3.Left + 5 && pcbHorse1.Left > pcbHorse2.Left + 1)
            {
                // durum ekrana yazdırıldı.
                lblRaceStatus.Text = "1 numaralı at öne geçti!";
            }
            else if (pcbHorse2.Left > pcbHorse1.Left + 5 && pcbHorse2.Left > pcbHorse3.Left + 1)
            {
                lblRaceStatus.Text = "2 numaralı at öne geçti!";
            }
            else if (pcbHorse3.Left > pcbHorse1.Left + 5 && pcbHorse3.Left > pcbHorse2.Left + 1)
            {
                lblRaceStatus.Text = "3 numaralı at öne geçti!";
            }
            else
            {
                lblRaceStatus.Text = "4 numaralı at öne geçti!";
            }
        }


        // başlat butonu ayarlandı.
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // oyunun başlaması için süre aktif edildi.
            timer.Enabled = true;
        }


        // reset butonu ayarlandı.
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // oyun resetlendiğinde label'ların temizlenmesi sağlandı.
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    // label'lara oyun başlamadan gerekli uyarılar sağlandı.
                    lblRaceStatus.Text = "Yarış Başlıyor!";
                    lblRaceResult.Text = "Yarışma Sonucu";
                    lblMetre.Text = "METRE";
                }
            }


            timer.Enabled = false;


            // oyun sıfırlandığında atların başlangıç noktasına geçmesi sağlandı.
            pcbHorse1.Left = 0;
            pcbHorse2.Left = 0;
            pcbHorse3.Left = 0;
            pcbHorse4.Left = 0;
            lblFinishLine.Text = " ";


            // oyun sıfırlandığında metre sayacının 0 olması sağlandı.
            lblCounter.Text = Convert.ToString(0);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // form1'in içinde tanımlanması için
        }


    }
}

