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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void organBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.organBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Organ". При необходимости она может быть перемещена или удалена.
            this.organTableAdapter.Fill(this.bD_sDataSet.Organ);

        }
    }
}
