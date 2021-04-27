using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBigNum_Click(object sender, EventArgs e)   // bu fonksiyonda en büyük sayı butonuna tıklandığında yapılacak işlemleri belirttik.
        {
            int num1 = Convert.ToInt32(txtBoxNum1.Text);           // int tipinde num1 değişkeni tanımlayıp veriyi txtBoxNum1'e text olarak çevirdik.
            int num2 = Convert.ToInt32(txtBoxNum2.Text);
            int num3 = Convert.ToInt32(txtBoxNum3.Text);

            if (num1 > num2 && num1 > num3)                                         // şartlarımızı belirttik.
            {
                MessageBox.Show(num1.ToString() + " sayısı en büyük sayıdır.");     // messageBox ile ekrana mesaj verdik.
            }
            else if (num2 > num1 && num2 > num3)
            {
                MessageBox.Show(num2.ToString() + " sayısı en büyük sayıdır.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                MessageBox.Show(num3.ToString() + " sayısı en büyük sayıdır.");
            }
            else if (num1 == num2 && num2 == num3)
            {
                MessageBox.Show("Tüm sayılar birbirine eşittir.");
            }
            else if (num1 == num2)
            {
                MessageBox.Show(num1.ToString() + " sayısı " + num2.ToString() + " sayısına eşittir.");
            }
            else if (num1 == num3)
            {
                MessageBox.Show(num1.ToString() + " sayısı " + num3.ToString() + " sayısına eşittir.");
            }
            else if (num2 == num3)
            {
                MessageBox.Show(num2.ToString() + " sayısı " + num3.ToString() + " sayısına eşittir.");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen tekrar deneyiniz..."); // hata mesajı yazdırdık.
            }
        }

        private void btnSmallNum_Click(object sender, EventArgs e)   // bu fonksiyonda en küçük sayı butonuna tıklandığında yapılacak işlemleri belirttik.
        {
            int num1 = Convert.ToInt32(txtBoxNum1.Text);
            int num2 = Convert.ToInt32(txtBoxNum2.Text);
            int num3 = Convert.ToInt32(txtBoxNum3.Text);

            if (num1 < num2 && num1 < num3)
            {
                MessageBox.Show(num1.ToString() + " sayısı en küçük sayıdır.");
            }
            else if (num2 < num1 && num2 < num3)
            {
                MessageBox.Show(num2.ToString() + " sayısı en küçük sayıdır.");
            }
            else if (num3 < num1 && num3 < num2)
            {
                MessageBox.Show(num3.ToString() + " sayısı en küçük sayıdır.");
            }
            else if (num1 == num2 && num2 == num3)
            {
                MessageBox.Show("Tüm sayılar birbirine eşittir.");
            }
            else if (num1 == num2)
            {
                MessageBox.Show(num1.ToString() + " sayısı " + num2.ToString() + " sayısına eşittir.");
            }
            else if (num1 == num3)
            {
                MessageBox.Show(num1.ToString() + " sayısı " + num3.ToString() + " sayısına eşittir.");
            }
            else if (num2 == num3)
            {
                MessageBox.Show(num2.ToString() + " sayısı " + num3.ToString() + " sayısına eşittir.");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen tekrar deneyiniz...");
            }
        }
    }
}
