using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderLootGenerator
{
    public partial class ItemDescriptionForm : Form
    {

        public string lastItemAdded = "";
        public ItemDescriptionForm()
        {
            InitializeComponent();
        }

        private void ItemDescriptionForm_Load(object sender, EventArgs e)
        {

        }
        //Method that adds selected in comboBox items to a list
        private void AddItemToShop_Click(object sender, EventArgs e)
        {
            shopTextBox.SelectedRtf += itemDescriptionRichBox.Rtf;
            lastItemAdded = itemDescriptionRichBox.Rtf;

        }

        private void DeleteLastElement_Click(object sender, EventArgs e)
        {
            //Add deleting last element - later
        }
    }
}

