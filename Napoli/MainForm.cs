/*
 * Сделано в SharpDevelop.
 * Пользователь: ashylnikov
 * Дата: 03.09.2013
 * Время: 10:38
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient adpt = new AddPatient();
            adpt.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            EditPatient edpt = new EditPatient();
            edpt.ShowDialog();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionaries dict = new Dictionaries();
            dict.ShowDialog();
        }
	}
}
