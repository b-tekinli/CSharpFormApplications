using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberWithoutRepetition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();                  // ArrayList class'ından nesne oluşturduk.
            Random random = new Random();                           // Random class'ından yeni nesne oluşturduk.

            int numberOfProduction = Convert.ToInt32(txtBoxNumberOfProduction.Text);
            int start = Convert.ToInt32(txtBoxStart.Text);          // değişken tanımlayıp int tipine çevirdik ve ilgili textBox'ın içine text olarak atadık.
            int finish = Convert.ToInt32(txtBoxFinish.Text);


            while (true)
            {
                numberOfProduction--;                               // üretilecek sayı adedini 1 azalttık.
                int number = random.Next(start, finish);            // start ve finish değerleri arasında random sayı üretimi yaptık.


                if (arrayList.IndexOf(number) != -1)                 // liste içinde sayıların indeks numarasını metot yardımıyla aratıp bulamaması sonucunda 0 döndürme şartını belirttik.
                {
                    continue;                                       // döngüye baştan başlasın diye continue deyimi ekledik.
                }
                else
                {
                    arrayList.Add(number);                          // liste için ürettiğimiz nesnenin içine sayıları ekliyoruz.
                    lstBoxRandom.Items.Add(number.ToString());      // random gelen sayıları listBox'ın içine item olarak ekliyoruz.
                }

                if (numberOfProduction == 0)                        // üretilen sayı adedinin 0 olma durumunu kontrol ettik.
                {
                    break;                                          // şart sağlandığında döngüden çıkmasını sağladık.
                }
            }


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txtBox = item as TextBox;
                    txtBox.Clear();
                    lstBoxRandom.Items.Clear();
                }
            }
        }
    }
}
