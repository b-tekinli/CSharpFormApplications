using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxAddSportsItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkedLstBoxItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedItem = e.Index;
            string selectedText = chkedLstBoxItems.Items[selectedItem].ToString();

            if (lstBoxAddItems.Items.IndexOf(selectedItem) > -1)
            {
                return;
            }

            bool isSelectedItem = chkedLstBoxItems.GetItemChecked(selectedItem);

            if (isSelectedItem == false)
            {
                lstBoxAddItems.Items.Add(selectedText);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            int add = chkedLstBoxItems.Items.Count;

            for (int i = 0; i < add; i++)
            {
                chkedLstBoxItems.SetItemChecked(i, true);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstBoxAddItems.Items.Clear();
        }
    }
}
