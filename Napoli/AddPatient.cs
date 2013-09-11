using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            //if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Visible = true;
                pictureBox1.ClientSize = new Size(200, 200);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                addImageBtn.Text = "Change image...";
            }

            openFileDialog.Dispose();
            //pictureBox1.Image(openFileDialog.FileName);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (SurnameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("No surname");
            }
            if (FirstNameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("No name");
            }
            if (PatronymicTxtBox.Text.Length == 0)
            {
                MessageBox.Show("No name");
            }
            if (dateBirthPicker.Value.ToString().Length == 0)
            {
                MessageBox.Show("No name");
            }
            if (AddressTxtBox.Text.Length == 0)
            {
                MessageBox.Show("No name");
            }
            if (PhoneTxtBox.Text.Length == 0)
            {
                MessageBox.Show("No name");
            }
            string rtn = "proc_add_new_patient";
            MySqlConnection conn = new MySqlConnection(Napoli.Properties.Settings.Default.napoliConnection);

            MySqlCommand cmd = new MySqlCommand(rtn, conn);
            cmd.Parameters.AddWithValue("p_surname", SurnameTxtBox.Text);
            cmd.Parameters.AddWithValue("p_firstname", FirstNameTxtBox.Text);
            cmd.Parameters.AddWithValue("p_patronymic", PatronymicTxtBox.Text);
            cmd.Parameters.AddWithValue("p_datebirth", (dateBirthPicker.Text).ToString());
            cmd.Parameters.AddWithValue("p_inn", SSNTxtBox.Text);
            cmd.Parameters.AddWithValue("p_phone", PhoneTxtBox.Text);
            cmd.Parameters.AddWithValue("p_email", emailTxtBox.Text);
            cmd.Parameters.AddWithValue("p_address", AddressTxtBox.Text);
            cmd.Parameters.AddWithValue("p_occupation", OccupationTxtBox.Text);
            cmd.Parameters.AddWithValue("p_job", JobTxtBox.Text);
            cmd.Parameters.AddWithValue("p_diseases", DiseasesChkbx.Text);

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //cmd = new MySqlCommand("INSERT INTO " + tableName + " ( Product, Manufacturer, Description, Price, Image) Values ('New_Product', 'New_Manufacturer', 'New_Description', '0', @Image)", conn);
            //cmd.Parameters.Add(new MySqlParameter("@Image", Convert.ToBase64String(ms.ToArray())));
            //cmd.ExecuteNonQuery();


            /* System.IO.FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
             System.IO.BufferedStream bf = new BufferedStream(fs);
             byte[] buffer = new byte[bf.Length];
             bf.Read(buffer, 0, buffer.Length);
             byte[] buffer_new = buffer;
             */
            cmd.Parameters.AddWithValue("p_photo", Convert.ToBase64String(ms.ToArray()));
            cmd.CommandType = CommandType.StoredProcedure;


        }



    }
}
