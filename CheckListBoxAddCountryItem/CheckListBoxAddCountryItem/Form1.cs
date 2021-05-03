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

        private void chkedLstBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedItem = e.Index;
            string selectedText = chkedLstBox.Items[selectedItem].ToString();

            if (lstBoxAdd.Items.IndexOf(selectedItem) > -1)
            {
                return;
            }

            bool isSelectedItem = chkedLstBox.GetItemChecked(selectedItem);

            if (isSelectedItem == false)
            {
                lstBoxAdd.Items.Add(selectedText);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int add = chkedLstBox.Items.Count;

            for (int i = 0; i < add; i++)
            {
                chkedLstBox.SetItemChecked(i, true);
            }
        }


        private void btnDell_Click(object sender, EventArgs e)
        {
            lstBoxAdd.Items.Clear();
        }
    }
}
