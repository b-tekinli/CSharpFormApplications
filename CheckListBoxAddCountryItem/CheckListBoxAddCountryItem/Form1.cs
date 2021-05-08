using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxAddCountryItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkedLstBox_ItemCheck(object sender, ItemCheckEventArgs e)        // checkedListBox'ın item check özelliği çalıştığında
        {
            int selectedItem = e.Index;
            string selectedText = chkedLstBox.Items[selectedItem].ToString();          // selectedText seçimi içinde checkedListBox'ın verilerini strin olarak tuttuk.

            if (lstBoxAdd.Items.IndexOf(selectedItem) > -1)                            // if ile listBox verilerinin index numarasını seçili olan verinin -1'den büyük olma şartını belirttik.
            {
                return;
            }

            bool isSelectedItem = chkedLstBox.GetItemChecked(selectedItem);             // verilerin seçili olup olmadığını kontrol ettik.

            if (isSelectedItem == false)                                                // seçili olma durumunun yanlış olması halinde çalışacak şartı belirttik.
            {
                lstBoxAdd.Items.Add(selectedText);                                      // seçilen itemleri listBox'a ekledik.
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)                           // ekleme butonunun çalışması halinde
        {
            int add = chkedLstBox.Items.Count;                                          // checkedListBox'taki itemleri saydırdık.

            for (int i = 0; i < add; i++)
            {
                chkedLstBox.SetItemChecked(i, true);
            }
        }


        private void btnDell_Click(object sender, EventArgs e)                          // verileri kaldırma butonunun çalışması halinde
        {
            lstBoxAdd.Items.Clear();                                                    // listBox verilerini sildirdik.
        }
    }
}
