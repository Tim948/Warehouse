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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void rasxodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rasxodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.bD_sDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.bD_sDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.rasxod". При необходимости она может быть перемещена или удалена.
            this.rasxodTableAdapter.Fill(this.bD_sDataSet.rasxod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
