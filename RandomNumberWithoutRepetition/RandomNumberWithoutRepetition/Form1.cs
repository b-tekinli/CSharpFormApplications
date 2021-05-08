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
            int start = Convert.ToInt32(txtBoxStart.Text);                                  // değişken tanımlayıp ilgili textBox içine text olarak yazdırdık.
            int finish = Convert.ToInt32(txtBoxFinish.Text);
            int blockNum = Convert.ToInt32(txtBoxBlockNum.Text);


            int[] arrayList = new int[blockNum];                                            // dizi içerisinde istenmeyen sayıları tuttuk.
            Random random = new Random();                                                   // tanımlı Random class'ından random adında nesne türettik.
            

            lstBoxRan.Items.Clear();                                                        // listBox içindeki verileri temizledik.


            for (int i = 0; i < arrayList.Length; i++)                                      // for döngüsü ile dizi elemanının uzunluğu kadar sayıları artırarak yazdırdık.
            {
                int numbers = random.Next(start, finish);                                   // random nesnesinde Next metodu ile başlangıç ve bitiş değerleri arasında sayı üretmeyi sağladık.
                int counter = 0;                                                            // sayaç için counter değişkeni tanımlayıp 0'dan başlattık.

                if (i == 0)                                                                 // if yardımı ile i değerinin 0'a eşit olması koşulunu belirttik.
                {
                    arrayList[i] = numbers;                                                 // liste içinde index sayısına i değerini verip numbers değişkenine atadık.
                }
                else
                {
                    foreach (var item in lstBoxRan.Items)                                   // listBox içindeki verileri foreach yardımıyla dönüyoruz.
                    {
                        int result = String.Compare(item.ToString(), numbers.ToString());   // sonuç için result değişkeninde compare metodu ile karşılaştırma yaptık.

                        if (result == 0)                                                    // result değişkeninin 0'a eşit olması durumunu kontrol ettik.
                        {
                            counter = -1;
                        }
                    }
                    if (counter == 0 && numbers != blockNum)                                // istenmeyen sayı durumunu ve sayaç durumunu kontrol ettik.
                    {
                        lstBoxRan.Items.Add(numbers.ToString());                            // belirtilen koşul sağlandığında listBox'a veri eklenmesini sağladık.
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }
        }
    }
}
