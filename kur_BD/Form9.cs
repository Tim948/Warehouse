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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void prixodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prixodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Organ". При необходимости она может быть перемещена или удалена.
            this.organTableAdapter.Fill(this.bD_sDataSet.Organ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.bD_sDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sost_naklad". При необходимости она может быть перемещена или удалена.
            this.sost_nakladTableAdapter.Fill(this.bD_sDataSet.Sost_naklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Prixod". При необходимости она может быть перемещена или удалена.
            this.prixodTableAdapter.Fill(this.bD_sDataSet.Prixod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
