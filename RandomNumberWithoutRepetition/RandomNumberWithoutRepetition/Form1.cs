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
            //ArrayList arrayList = new ArrayList();                  // dizi listesi class'ından nesne oluşturduk.
            //Random random = new Random();                           // random class'ından yeni nesne oluşturduk.

            //int numberOfProduction = Convert.ToInt32(txtBoxNumberOfProduction.Text);
            //int start = Convert.ToInt32(txtBoxStart.Text);          // değişken tanımlayıp int tipine çevirdik ve ilgili textBox'ın içine text olarak atadık.
            //int finish = Convert.ToInt32(txtBoxFinish.Text);


            //while (true)
            //{
            //    numberOfProduction--;                               // üretilecek sayı adedini 1 azalttık.
            //    int number = random.Next(start, finish);            // start ve finish değerleri arasında random sayı üretimi yaptık.


            //    if (arrayList.IndexOf(number) == 0)                // liste içinde sayıların indeks numarasını metot yardımıyla aratıp bulamaması sonucunda 0 döndürme şartını belirttik.
            //    {
            //        continue;                                       // döngüye baştan başlasın diye continue deyimi ekledik.
            //    }
            //    else if (numberOfProduction == 0)                   // üretilen sayı adedinin 0 olma durumunu kontrol ettik.
            //    {
            //        break;                                          // şart sağlandığında döngüden çıkmasını sağladık.
            //    }
            //    else
            //    {
            //        arrayList.Add(number);                          // liste için ürettiğimiz nesnenin içine sayıları ekliyoruz.
            //        lstBoxRandomSmall.Items.Add(number.ToString());      // random gelen sayıları listBox'ın içine item olarak ekliyoruz.
            //    }
            //}


            lstBoxRandomSmall.Items.Clear();
            lstBoxRandomBig.Items.Clear();

            ArrayList arrayList = new ArrayList();                  // dizi listesi class'ından nesne oluşturduk.
            Random random = new Random();                             // random class'ından yeni nesne oluşturduk.

            int start = Int32.Parse(txtBoxStart.Text);            // değişken tanımlayıp int tipine çevirdik ve ilgili textBox'ın içine text olarak atadık.
            int finish = Int32.Parse(txtBoxFinish.Text);
            int numberOfProduction = Int32.Parse(txtBoxNumberOfProduction.Text);


            for (int i = 1; i < 20; i++)
            {
                int number = random.Next(start, finish);

                if (number < (numberOfProduction / 2))
                {
                    lstBoxRandomSmall.Items.Add(number);
                }
                else if (numberOfProduction == 0)
                {
                    break;
                }
                else if (arrayList.IndexOf(number) == -1)
                {
                    continue;
                }
                else
                {
                    arrayList.Add(number);
                    lstBoxRandomBig.Items.Add(number);
                }
            }
        }
    }
}
