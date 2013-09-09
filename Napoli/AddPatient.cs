using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Napoli.classes;
using System.IO;


namespace Napoli
{
    public partial class AddPatient : Form
    {
        private string[] coloursArr = { "Red", "Green", "Black", "White", "Orange", "Yellow", "Blue", "Maroon", "Pink", "Purple" };

        public AddPatient()
        {
            InitializeComponent();
            DiseasesChkbx.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccb_ItemCheck);

        }

        private void ccb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CCBoxItem item = DiseasesChkbx.Items[e.Index] as CCBoxItem;
           

        }

        private void ccb_DropDownClosed(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("Items checked: ");
            foreach (CCBoxItem item in DiseasesChkbx.CheckedItems)
            {
                sb.Append(item.Name).Append(DiseasesChkbx.ValueSeparator);
            }
            sb.Remove(sb.Length - DiseasesChkbx.ValueSeparator.Length, DiseasesChkbx.ValueSeparator.Length);
            

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < coloursArr.Length; i++)
            {
                CCBoxItem item = new CCBoxItem(coloursArr[i], i);
                DiseasesChkbx.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            DiseasesChkbx.MaxDropDownItems = 7;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            DiseasesChkbx.DisplayMember = "Name";
            DiseasesChkbx.ValueSeparator = ", ";
            

        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            AddPatient.ActiveForm.Close();
        }



    }
}
