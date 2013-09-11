using Napoli.classes;
namespace Napoli
{
    partial class AddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiseasesLbl = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.JobTxtBox = new System.Windows.Forms.TextBox();
            this.DiseasesChkbx = new Napoli.classes.CheckedComboBox();
            this.JobLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.dateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.OccupationLbl = new System.Windows.Forms.Label();
            this.DateBirthLbl = new System.Windows.Forms.Label();
            this.PatronymicLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.PatronymicTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.OccupationTxtBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.declineBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.napoliDataSet1 = new Napoli.napoliDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.SSNTxtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.SSNTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.emailTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addImageBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DiseasesLbl);
            this.panel1.Controls.Add(this.AddressTxtBox);
            this.panel1.Controls.Add(this.PhoneLbl);
            this.panel1.Controls.Add(this.PhoneTxtBox);
            this.panel1.Controls.Add(this.JobTxtBox);
            this.panel1.Controls.Add(this.DiseasesChkbx);
            this.panel1.Controls.Add(this.JobLbl);
            this.panel1.Controls.Add(this.AddressLbl);
            this.panel1.Controls.Add(this.dateBirthPicker);
            this.panel1.Controls.Add(this.OccupationLbl);
            this.panel1.Controls.Add(this.DateBirthLbl);
            this.panel1.Controls.Add(this.PatronymicLbl);
            this.panel1.Controls.Add(this.FirstNameLbl);
            this.panel1.Controls.Add(this.SurnameLbl);
            this.panel1.Controls.Add(this.PatronymicTxtBox);
            this.panel1.Controls.Add(this.FirstNameTxtBox);
            this.panel1.Controls.Add(this.SurnameTxtBox);
            this.panel1.Controls.Add(this.OccupationTxtBox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 266);
            this.panel1.TabIndex = 10;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(280, 101);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(135, 20);
            this.emailTxtBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "E-mail: ";
            // 
            // addImageBtn
            // 
            this.addImageBtn.Location = new System.Drawing.Point(483, 238);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(98, 23);
            this.addImageBtn.TabIndex = 17;
            this.addImageBtn.Text = "Add image...";
            this.addImageBtn.UseVisualStyleBackColor = true;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(424, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // DiseasesLbl
            // 
            this.DiseasesLbl.AutoSize = true;
            this.DiseasesLbl.Location = new System.Drawing.Point(3, 140);
            this.DiseasesLbl.Name = "DiseasesLbl";
            this.DiseasesLbl.Size = new System.Drawing.Size(56, 13);
            this.DiseasesLbl.TabIndex = 0;
            this.DiseasesLbl.Text = "Diseases: ";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(60, 72);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(139, 20);
            this.AddressTxtBox.TabIndex = 4;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(211, 74);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(44, 13);
            this.PhoneLbl.TabIndex = 5;
            this.PhoneLbl.Text = "Phone: ";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(280, 68);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(135, 20);
            this.PhoneTxtBox.TabIndex = 5;
            // 
            // JobTxtBox
            // 
            this.JobTxtBox.Location = new System.Drawing.Point(60, 103);
            this.JobTxtBox.Name = "JobTxtBox";
            this.JobTxtBox.Size = new System.Drawing.Size(139, 20);
            this.JobTxtBox.TabIndex = 6;
            // 
            // DiseasesChkbx
            // 
            this.DiseasesChkbx.CheckOnClick = true;
            this.DiseasesChkbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DiseasesChkbx.DropDownHeight = 1;
            this.DiseasesChkbx.IntegralHeight = false;
            this.DiseasesChkbx.Location = new System.Drawing.Point(60, 137);
            this.DiseasesChkbx.Name = "DiseasesChkbx";
            this.DiseasesChkbx.Size = new System.Drawing.Size(139, 21);
            this.DiseasesChkbx.TabIndex = 8;
            this.DiseasesChkbx.ValueSeparator = ", ";
            // 
            // JobLbl
            // 
            this.JobLbl.AutoSize = true;
            this.JobLbl.Location = new System.Drawing.Point(3, 103);
            this.JobLbl.Name = "JobLbl";
            this.JobLbl.Size = new System.Drawing.Size(30, 13);
            this.JobLbl.TabIndex = 9;
            this.JobLbl.Text = "Job: ";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(3, 75);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(51, 13);
            this.AddressLbl.TabIndex = 10;
            this.AddressLbl.Text = "Address: ";
            // 
            // dateBirthPicker
            // 
            this.dateBirthPicker.Location = new System.Drawing.Point(64, 38);
            this.dateBirthPicker.Name = "dateBirthPicker";
            this.dateBirthPicker.Size = new System.Drawing.Size(135, 20);
            this.dateBirthPicker.TabIndex = 3;
            // 
            // OccupationLbl
            // 
            this.OccupationLbl.AutoSize = true;
            this.OccupationLbl.Location = new System.Drawing.Point(211, 140);
            this.OccupationLbl.Name = "OccupationLbl";
            this.OccupationLbl.Size = new System.Drawing.Size(68, 13);
            this.OccupationLbl.TabIndex = 11;
            this.OccupationLbl.Text = "Occupation: ";
            // 
            // DateBirthLbl
            // 
            this.DateBirthLbl.AutoSize = true;
            this.DateBirthLbl.Location = new System.Drawing.Point(3, 44);
            this.DateBirthLbl.Name = "DateBirthLbl";
            this.DateBirthLbl.Size = new System.Drawing.Size(60, 13);
            this.DateBirthLbl.TabIndex = 12;
            this.DateBirthLbl.Text = "Date Birth: ";
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Location = new System.Drawing.Point(421, 9);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(65, 13);
            this.PatronymicLbl.TabIndex = 13;
            this.PatronymicLbl.Text = "Patronymic: ";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(211, 9);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(63, 13);
            this.FirstNameLbl.TabIndex = 14;
            this.FirstNameLbl.Text = "Fisrt Name: ";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(3, 9);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(55, 13);
            this.SurnameLbl.TabIndex = 15;
            this.SurnameLbl.Text = "Surname: ";
            // 
            // PatronymicTxtBox
            // 
            this.PatronymicTxtBox.Location = new System.Drawing.Point(483, 6);
            this.PatronymicTxtBox.Name = "PatronymicTxtBox";
            this.PatronymicTxtBox.Size = new System.Drawing.Size(135, 20);
            this.PatronymicTxtBox.TabIndex = 2;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(280, 6);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(135, 20);
            this.FirstNameTxtBox.TabIndex = 1;
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(64, 6);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(135, 20);
            this.SurnameTxtBox.TabIndex = 0;
            // 
            // OccupationTxtBox
            // 
            this.OccupationTxtBox.Location = new System.Drawing.Point(280, 140);
            this.OccupationTxtBox.Name = "OccupationTxtBox";
            this.OccupationTxtBox.Size = new System.Drawing.Size(135, 20);
            this.OccupationTxtBox.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(59, 272);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // declineBtn
            // 
            this.declineBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.declineBtn.Location = new System.Drawing.Point(498, 272);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(75, 23);
            this.declineBtn.TabIndex = 0;
            this.declineBtn.Text = "Decline";
            this.declineBtn.Click += new System.EventHandler(this.declineBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All images|*.jpg,*.png,*.bmp|Jpeg files|*.jpg|*.png|*.bmp";
            this.openFileDialog.Title = "Select Image...";
            // 
            // napoliDataSet1
            // 
            this.napoliDataSet1.DataSetName = "napoliDataSet";
            this.napoliDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "SSN: ";
            // 
            // SSNTxtBox
            // 
            this.SSNTxtBox.Location = new System.Drawing.Point(280, 37);
            this.SSNTxtBox.Name = "SSNTxtBox";
            this.SSNTxtBox.Size = new System.Drawing.Size(135, 20);
            this.SSNTxtBox.TabIndex = 21;
            // 
            // AddPatient
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.declineBtn;
            this.ClientSize = new System.Drawing.Size(640, 307);
            this.Controls.Add(this.declineBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatient";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PatronymicTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox SurnameTxtBox;
        private System.Windows.Forms.TextBox OccupationTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button declineBtn;
        private System.Windows.Forms.Label OccupationLbl;
        private System.Windows.Forms.Label DateBirthLbl;
        private System.Windows.Forms.Label PatronymicLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.DateTimePicker dateBirthPicker;
        private CheckedComboBox DiseasesChkbx;
        private System.Windows.Forms.Label JobLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox JobTxtBox;
        private System.Windows.Forms.Label DiseasesLbl;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addImageBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label1;
        private napoliDataSet napoliDataSet1;
        private System.Windows.Forms.TextBox SSNTxtBox;
        private System.Windows.Forms.Label label2;

    }
}