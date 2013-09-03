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
			this.tabPatients = new System.Windows.Forms.TabPage();
			this.MainMenus = new System.Windows.Forms.MenuStrip();
			this.FileMenus = new System.Windows.Forms.ToolStripMenuItem();
			this.Helpmenus = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsMenus = new System.Windows.Forms.ToolStripMenuItem();
			this.PersonalityMenus = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenus = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.TabContainer.SuspendLayout();
			this.MainMenus.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabContainer
			// 
			this.TabContainer.Controls.Add(this.tabScheduler);
			this.TabContainer.Controls.Add(this.tabPatients);
			this.TabContainer.HotTrack = true;
			this.TabContainer.Location = new System.Drawing.Point(0, 27);
			this.TabContainer.Name = "TabContainer";
			this.TabContainer.SelectedIndex = 0;
			this.TabContainer.Size = new System.Drawing.Size(1016, 600);
			this.TabContainer.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.TabContainer.TabIndex = 0;
			// 
			// tabScheduler
			// 
			this.tabScheduler.Location = new System.Drawing.Point(4, 22);
			this.tabScheduler.Name = "tabScheduler";
			this.tabScheduler.Padding = new System.Windows.Forms.Padding(3);
			this.tabScheduler.Size = new System.Drawing.Size(1008, 574);
			this.tabScheduler.TabIndex = 0;
			this.tabScheduler.Text = "Scheduler";
			this.tabScheduler.UseVisualStyleBackColor = true;
			// 
			// tabPatients
			// 
			this.tabPatients.Location = new System.Drawing.Point(4, 22);
			this.tabPatients.Name = "tabPatients";
			this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
			this.tabPatients.Size = new System.Drawing.Size(1008, 574);
			this.tabPatients.TabIndex = 1;
			this.tabPatients.Text = "Patients";
			this.tabPatients.UseVisualStyleBackColor = true;
			// 
			// MainMenus
			// 
			this.MainMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.FileMenus,
									this.SettingsMenus,
									this.ExitMenus});
			this.MainMenus.Location = new System.Drawing.Point(0, 0);
			this.MainMenus.Name = "MainMenus";
			this.MainMenus.Size = new System.Drawing.Size(1016, 24);
			this.MainMenus.TabIndex = 1;
			this.MainMenus.Text = "menuStrip1";
			// 
			// FileMenus
			// 
			this.FileMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Helpmenus});
			this.FileMenus.Name = "FileMenus";
			this.FileMenus.Size = new System.Drawing.Size(35, 20);
			this.FileMenus.Text = "File";
			// 
			// Helpmenus
			// 
			this.Helpmenus.Name = "Helpmenus";
			this.Helpmenus.ShortcutKeyDisplayString = "Alt+X";
			this.Helpmenus.Size = new System.Drawing.Size(126, 22);
			this.Helpmenus.Text = "Exit";
			this.Helpmenus.Click += new System.EventHandler(this.ClickOnExitInMenus);
			// 
			// SettingsMenus
			// 
			this.SettingsMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.PersonalityMenus});
			this.SettingsMenus.Name = "SettingsMenus";
			this.SettingsMenus.Size = new System.Drawing.Size(58, 20);
			this.SettingsMenus.Text = "Settings";
			// 
			// PersonalityMenus
			// 
			this.PersonalityMenus.Name = "PersonalityMenus";
			this.PersonalityMenus.Size = new System.Drawing.Size(127, 22);
			this.PersonalityMenus.Text = "Personality";
			// 
			// ExitMenus
			// 
			this.ExitMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.ExitMenus.Name = "ExitMenus";
			this.ExitMenus.Size = new System.Drawing.Size(40, 20);
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
			this.StatusBar.Location = new System.Drawing.Point(0, 719);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(1016, 22);
			this.StatusBar.TabIndex = 2;
			this.StatusBar.Text = "statusStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.TabContainer);
			this.Controls.Add(this.MainMenus);
			this.HelpButton = true;
			this.MainMenuStrip = this.MainMenus;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Napoli";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.TabContainer.ResumeLayout(false);
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
		
		
	}
}
