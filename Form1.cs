using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание новой записи 
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Сохранение новой записи в БД
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Кнопка "Справка"
            MessageBox.Show("Феткулин Григорий - База данных Клиенты 1.0, 2022", "О программе");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Кнопка "Выход"
            Application.Exit();
        }
    }
}
