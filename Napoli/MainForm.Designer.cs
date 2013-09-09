/*
 * Сделано в SharpDevelop.
 * Пользователь: ashylnikov
 * Дата: 03.09.2013
 * Время: 10:38
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Napoli
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.tabScheduler = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.napoliDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.napoliDataSet1 = new Napoli.napoliDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.operatorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenus = new System.Windows.Forms.MenuStrip();
            this.FileMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.Helpmenus = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalityMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatorsTableAdapter = new Napoli.napoliDataSetTableAdapters.operatorsTableAdapter();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Napoli.napoliDataSetTableAdapters.patientsTableAdapter();
            this.vpatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_patientsTableAdapter = new Napoli.napoliDataSetTableAdapters.v_patientsTableAdapter();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientpatronimycDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientinnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabContainer.SuspendLayout();
            this.tabScheduler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource1)).BeginInit();
            this.MainMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpatientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabContainer
            // 
            this.TabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContainer.Controls.Add(this.tabScheduler);
            this.TabContainer.Controls.Add(this.tabPatients);
            this.TabContainer.HotTrack = true;
            this.TabContainer.Location = new System.Drawing.Point(0, 27);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(746, 299);
            this.TabContainer.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabContainer.TabIndex = 0;
            // 
            // tabScheduler
            // 
            this.tabScheduler.Controls.Add(this.dataGridView1);
            this.tabScheduler.Location = new System.Drawing.Point(4, 22);
            this.tabScheduler.Name = "tabScheduler";
            this.tabScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tabScheduler.Size = new System.Drawing.Size(738, 273);
            this.tabScheduler.TabIndex = 0;
            this.tabScheduler.Text = "Scheduler";
            this.tabScheduler.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Worker,
            this.Patient});
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Врач";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Width = 200;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.Width = 800;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.dataGridView2);
            this.tabPatients.Controls.Add(this.button1);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(738, 273);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientidDataGridViewTextBoxColumn,
            this.patientsurnameDataGridViewTextBoxColumn,
            this.patientfirstnameDataGridViewTextBoxColumn,
            this.patientpatronimycDataGridViewTextBoxColumn,
            this.patientinnDataGridViewTextBoxColumn,
            this.patientphoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vpatientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(4, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(734, 263);
            this.dataGridView2.TabIndex = 1;
            // 
            // napoliDataSet1BindingSource
            // 
            this.napoliDataSet1BindingSource.DataSource = this.napoliDataSet1;
            this.napoliDataSet1BindingSource.Position = 0;
            // 
            // napoliDataSet1
            // 
            this.napoliDataSet1.DataSetName = "napoliDataSet";
            this.napoliDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operatorsBindingSource1
            // 
            this.operatorsBindingSource1.DataMember = "operators";
            this.operatorsBindingSource1.DataSource = this.napoliDataSet1BindingSource;
            // 
            // MainMenus
            // 
            this.MainMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenus,
            this.SettingsMenus,
            this.ExitMenus});
            this.MainMenus.Location = new System.Drawing.Point(0, 0);
            this.MainMenus.Name = "MainMenus";
            this.MainMenus.Size = new System.Drawing.Size(746, 24);
            this.MainMenus.TabIndex = 1;
            this.MainMenus.Text = "menuStrip1";
            // 
            // FileMenus
            // 
            this.FileMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Helpmenus});
            this.FileMenus.Name = "FileMenus";
            this.FileMenus.Size = new System.Drawing.Size(37, 20);
            this.FileMenus.Text = "File";
            // 
            // Helpmenus
            // 
            this.Helpmenus.Name = "Helpmenus";
            this.Helpmenus.ShortcutKeyDisplayString = "Alt+X";
            this.Helpmenus.Size = new System.Drawing.Size(129, 22);
            this.Helpmenus.Text = "Exit";
            this.Helpmenus.Click += new System.EventHandler(this.ClickOnExitInMenus);
            // 
            // SettingsMenus
            // 
            this.SettingsMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonalityMenus});
            this.SettingsMenus.Name = "SettingsMenus";
            this.SettingsMenus.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenus.Text = "Settings";
            // 
            // PersonalityMenus
            // 
            this.PersonalityMenus.Name = "PersonalityMenus";
            this.PersonalityMenus.Size = new System.Drawing.Size(132, 22);
            this.PersonalityMenus.Text = "Personality";
            // 
            // ExitMenus
            // 
            this.ExitMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ExitMenus.Name = "ExitMenus";
            this.ExitMenus.Size = new System.Drawing.Size(44, 20);
            this.ExitMenus.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ClickonAbout);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 329);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(746, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataMember = "operators";
            this.operatorsBindingSource.DataSource = this.napoliDataSet1BindingSource;
            // 
            // operatorsTableAdapter
            // 
            this.operatorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.napoliDataSet1BindingSource;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // vpatientsBindingSource
            // 
            this.vpatientsBindingSource.DataMember = "v_patients";
            this.vpatientsBindingSource.DataSource = this.napoliDataSet1BindingSource;
            // 
            // v_patientsTableAdapter
            // 
            this.v_patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // patientsurnameDataGridViewTextBoxColumn
            // 
            this.patientsurnameDataGridViewTextBoxColumn.DataPropertyName = "patient_surname";
            this.patientsurnameDataGridViewTextBoxColumn.HeaderText = "patient_surname";
            this.patientsurnameDataGridViewTextBoxColumn.Name = "patientsurnameDataGridViewTextBoxColumn";
            // 
            // patientfirstnameDataGridViewTextBoxColumn
            // 
            this.patientfirstnameDataGridViewTextBoxColumn.DataPropertyName = "patient_firstname";
            this.patientfirstnameDataGridViewTextBoxColumn.HeaderText = "patient_firstname";
            this.patientfirstnameDataGridViewTextBoxColumn.Name = "patientfirstnameDataGridViewTextBoxColumn";
            // 
            // patientpatronimycDataGridViewTextBoxColumn
            // 
            this.patientpatronimycDataGridViewTextBoxColumn.DataPropertyName = "patient_patronimyc";
            this.patientpatronimycDataGridViewTextBoxColumn.HeaderText = "patient_patronimyc";
            this.patientpatronimycDataGridViewTextBoxColumn.Name = "patientpatronimycDataGridViewTextBoxColumn";
            // 
            // patientinnDataGridViewTextBoxColumn
            // 
            this.patientinnDataGridViewTextBoxColumn.DataPropertyName = "patient_inn";
            this.patientinnDataGridViewTextBoxColumn.HeaderText = "patient_inn";
            this.patientinnDataGridViewTextBoxColumn.Name = "patientinnDataGridViewTextBoxColumn";
            // 
            // patientphoneDataGridViewTextBoxColumn
            // 
            this.patientphoneDataGridViewTextBoxColumn.DataPropertyName = "patient_phone";
            this.patientphoneDataGridViewTextBoxColumn.HeaderText = "patient_phone";
            this.patientphoneDataGridViewTextBoxColumn.Name = "patientphoneDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 351);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.TabContainer);
            this.Controls.Add(this.MainMenus);
            this.HelpButton = true;
            this.MainMenuStrip = this.MainMenus;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napoli";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabContainer.ResumeLayout(false);
            this.tabScheduler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napoliDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource1)).EndInit();
            this.MainMenus.ResumeLayout(false);
            this.MainMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpatientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PersonalityMenus;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripMenuItem ExitMenus;
		private System.Windows.Forms.ToolStripMenuItem SettingsMenus;
		private System.Windows.Forms.ToolStripMenuItem Helpmenus;
		private System.Windows.Forms.ToolStripMenuItem FileMenus;
		private System.Windows.Forms.MenuStrip MainMenus;
		private System.Windows.Forms.TabPage tabPatients;
		private System.Windows.Forms.TabPage tabScheduler;
		private System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.BindingSource napoliDataSet1BindingSource;
        private napoliDataSet napoliDataSet1;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private napoliDataSetTableAdapters.operatorsTableAdapter operatorsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private napoliDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource operatorsBindingSource1;
        private System.Windows.Forms.BindingSource vpatientsBindingSource;
        private napoliDataSetTableAdapters.v_patientsTableAdapter v_patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientpatronimycDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientinnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientphoneDataGridViewTextBoxColumn;
		
		
	}
}
