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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void vid_rasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vid_rasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_sDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_sDataSet.Vid_ras". При необходимости она может быть перемещена или удалена.
            this.vid_rasTableAdapter.Fill(this.bD_sDataSet.Vid_ras);

        }
    }
}
