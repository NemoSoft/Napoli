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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "napoliDataSet1.v_patients". При необходимости она может быть перемещена или удалена.
            this.v_patientsTableAdapter.Fill(this.napoliDataSet1.v_patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "napoliDataSet1.patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.napoliDataSet1.patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "napoliDataSet1.operators". При необходимости она может быть перемещена или удалена.
            this.operatorsTableAdapter.Fill(this.napoliDataSet1.operators);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
	}
}
