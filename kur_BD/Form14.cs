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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void sost_nakladBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sost_nakladBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.bD_sDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Sost_naklad". При необходимости она может быть перемещена или удалена.
            this.sost_nakladTableAdapter.Fill(this.bD_sDataSet.Sost_naklad);

        }
    }
}
