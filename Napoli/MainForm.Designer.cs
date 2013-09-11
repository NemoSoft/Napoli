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
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.tabScheduler = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.editPatientBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MainMenus = new System.Windows.Forms.MenuStrip();
            this.FileMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.Helpmenus = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalityMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabContainer.SuspendLayout();
            this.tabScheduler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPatients.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.MainMenus.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.panel1);
            this.tabPatients.Controls.Add(this.dataGridView2);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(738, 273);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.editPatientBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 38);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Patient";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // editPatientBtn
            // 
            this.editPatientBtn.Location = new System.Drawing.Point(316, 12);
            this.editPatientBtn.Name = "editPatientBtn";
            this.editPatientBtn.Size = new System.Drawing.Size(75, 23);
            this.editPatientBtn.TabIndex = 1;
            this.editPatientBtn.Text = "Edit Patient";
            this.editPatientBtn.UseVisualStyleBackColor = true;
            this.editPatientBtn.Click += new System.EventHandler(this.editPatientBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(734, 223);
            this.dataGridView2.TabIndex = 1;
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
            this.Helpmenus.Size = new System.Drawing.Size(152, 22);
            this.Helpmenus.Text = "Exit";
            this.Helpmenus.Click += new System.EventHandler(this.ClickOnExitInMenus);
            // 
            // SettingsMenus
            // 
            this.SettingsMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonalityMenus,
            this.referencesToolStripMenuItem});
            this.SettingsMenus.Name = "SettingsMenus";
            this.SettingsMenus.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenus.Text = "Settings";
            // 
            // PersonalityMenus
            // 
            this.PersonalityMenus.Name = "PersonalityMenus";
            this.PersonalityMenus.Size = new System.Drawing.Size(152, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.referencesToolStripMenuItem.Text = "Dictionaries...";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.MainMenus.ResumeLayout(false);
            this.MainMenus.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
		
		
	}
}
