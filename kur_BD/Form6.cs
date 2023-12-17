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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void ost_sBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ost_sBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.bD_sDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.bD_sDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Ost_s". При необходимости она может быть перемещена или удалена.
            this.ost_sTableAdapter.Fill(this.bD_sDataSet.Ost_s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
