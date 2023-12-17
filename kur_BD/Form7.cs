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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void rasxodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rasxodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.rasxod". При необходимости она может быть перемещена или удалена.
            this.rasxodTableAdapter.Fill(this.bD_sDataSet.rasxod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < rasxodDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < rasxodDataGridView.RowCount - 1; j++)
                {
                    rasxodDataGridView[i, j].Style.BackColor = Color.White;
                    rasxodDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < rasxodDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < rasxodDataGridView.RowCount - 1; j++)
                {
                    if (rasxodDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        rasxodDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        rasxodDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rasxodBindingSource.Filter = "Podraz='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rasxodBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form8 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form8();
            t.Visible = true;
        }
    }
}
