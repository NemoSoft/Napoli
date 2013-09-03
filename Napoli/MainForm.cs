/*
 * Сделано в SharpDevelop.
 * Пользователь: ashylnikov
 * Дата: 03.09.2013
 * Время: 10:38
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Napoli
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ClickOnExitInMenus(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void ClickonAbout(object sender, System.EventArgs e)
		{
			AboutBox box = new AboutBox();
     		box.Show();
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
	}
}
