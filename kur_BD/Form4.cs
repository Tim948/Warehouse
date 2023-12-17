using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kur_BD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void skladBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skladBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.bD_sDataSet.Sklad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < skladDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < skladDataGridView.RowCount - 1; j++)
                {
                    skladDataGridView[i, j].Style.BackColor = Color.White;
                    skladDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < skladDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < skladDataGridView.RowCount - 1; j++)
                {
                    if (skladDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        skladDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        skladDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skladBindingSource.Filter = "F_k='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skladBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form5 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form5();
            t.Visible = true;
        }
    }
}
