using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintNumbersSideBySide
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtBoxNumStart.Text);    // int tipinde num1 değişkeni tanımlayıp veriyi txtBoxNum1'e text olarak çevirdik.
            int num2 = Convert.ToInt32(txtBoxNumFinish.Text);
            int num3 = Convert.ToInt32(txtBoxNumIncreaseValue.Text);

            for (int i = num1; i <= num2; i+=num3)              // döngü ile tanımlanan değerden istenen değere kadar sayıları 1 artırmayı sağladık.
            {
                if (i == num2)                                  // başlangıç değerinin bitiş değerine eşit olma durumunu kontrol ettik.
                {
                    txtBoxShow.Text += i.ToString();            // textBox'ın içine döngü içinde tanımladığımız değişkenin metodu ile stringe çevirip yazdırdık.
                }
                else
                {
                    txtBoxShow.Text += i.ToString() + ", ";     // sayılar arasına virgül koyarak yazdırdık.
                }
            }

            if (num2 < num1)                                    // başlangıç değerinin bitiş değerinden daha küçük olma durumunu kontrol ettik.
            {
                MessageBox.Show("Başlangıç değeri bitiş değerinden daha küçük olmalıdır.");
            }
        }
    }
}
