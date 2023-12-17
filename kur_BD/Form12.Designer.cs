namespace kur_BD
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lim_kLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label kolLabel;
            System.Windows.Forms.Label vid_rasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.sost_rasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sost_rasTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Sost_rasTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.rasxodTableAdapter = new kur_BD.BD_sDataSetTableAdapters.rasxodTableAdapter();
            this.vid_rasTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Vid_rasTableAdapter();
            this.sost_rasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sost_rasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_lim_kComboBox = new System.Windows.Forms.ComboBox();
            this.rasxodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vid_rasComboBox = new System.Windows.Forms.ComboBox();
            this.vidrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.kolMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            id_lim_kLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            kolLabel = new System.Windows.Forms.Label();
            vid_rasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_rasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_rasBindingNavigator)).BeginInit();
            this.sost_rasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidrasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lim_kLabel
            // 
            id_lim_kLabel.AutoSize = true;
            id_lim_kLabel.Location = new System.Drawing.Point(12, 49);
            id_lim_kLabel.Name = "id_lim_kLabel";
            id_lim_kLabel.Size = new System.Drawing.Size(136, 13);
            id_lim_kLabel.TabIndex = 1;
            id_lim_kLabel.Text = "Номер расходов по базе:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(112, 73);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Дата:";
            // 
            // kolLabel
            // 
            kolLabel.AutoSize = true;
            kolLabel.Location = new System.Drawing.Point(79, 99);
            kolLabel.Name = "kolLabel";
            kolLabel.Size = new System.Drawing.Size(69, 13);
            kolLabel.TabIndex = 5;
            kolLabel.Text = "Количество:";
            // 
            // vid_rasLabel
            // 
            vid_rasLabel.AutoSize = true;
            vid_rasLabel.Location = new System.Drawing.Point(75, 128);
            vid_rasLabel.Name = "vid_rasLabel";
            vid_rasLabel.Size = new System.Drawing.Size(73, 13);
            vid_rasLabel.TabIndex = 7;
            vid_rasLabel.Text = "Вид расхода:";
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sost_rasBindingSource
            // 
            this.sost_rasBindingSource.DataMember = "Sost_ras";
            this.sost_rasBindingSource.DataSource = this.bD_sDataSet;
            // 
            // sost_rasTableAdapter
            // 
            this.sost_rasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = this.rasxodTableAdapter;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.Sost_nakladTableAdapter = null;
            this.tableAdapterManager.Sost_rasTableAdapter = this.sost_rasTableAdapter;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = this.vid_rasTableAdapter;
            // 
            // rasxodTableAdapter
            // 
            this.rasxodTableAdapter.ClearBeforeFill = true;
            // 
            // vid_rasTableAdapter
            // 
            this.vid_rasTableAdapter.ClearBeforeFill = true;
            // 
            // sost_rasBindingNavigator
            // 
            this.sost_rasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sost_rasBindingNavigator.BindingSource = this.sost_rasBindingSource;
            this.sost_rasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sost_rasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sost_rasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sost_rasBindingNavigatorSaveItem});
            this.sost_rasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sost_rasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sost_rasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sost_rasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sost_rasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sost_rasBindingNavigator.Name = "sost_rasBindingNavigator";
            this.sost_rasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sost_rasBindingNavigator.Size = new System.Drawing.Size(303, 25);
            this.sost_rasBindingNavigator.TabIndex = 0;
            this.sost_rasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sost_rasBindingNavigatorSaveItem
            // 
            this.sost_rasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sost_rasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sost_rasBindingNavigatorSaveItem.Image")));
            this.sost_rasBindingNavigatorSaveItem.Name = "sost_rasBindingNavigatorSaveItem";
            this.sost_rasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sost_rasBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sost_rasBindingNavigatorSaveItem.Click += new System.EventHandler(this.sost_rasBindingNavigatorSaveItem_Click);
            // 
            // id_lim_kComboBox
            // 
            this.id_lim_kComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sost_rasBindingSource, "id_lim_k", true));
            this.id_lim_kComboBox.DataSource = this.rasxodBindingSource;
            this.id_lim_kComboBox.DisplayMember = "id";
            this.id_lim_kComboBox.FormattingEnabled = true;
            this.id_lim_kComboBox.Location = new System.Drawing.Point(154, 46);
            this.id_lim_kComboBox.Name = "id_lim_kComboBox";
            this.id_lim_kComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_lim_kComboBox.TabIndex = 2;
            // 
            // rasxodBindingSource
            // 
            this.rasxodBindingSource.DataMember = "rasxod";
            this.rasxodBindingSource.DataSource = this.bD_sDataSet;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sost_rasBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(154, 73);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // vid_rasComboBox
            // 
            this.vid_rasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sost_rasBindingSource, "vid_ras", true));
            this.vid_rasComboBox.DataSource = this.vidrasBindingSource;
            this.vid_rasComboBox.DisplayMember = "id";
            this.vid_rasComboBox.FormattingEnabled = true;
            this.vid_rasComboBox.Location = new System.Drawing.Point(154, 125);
            this.vid_rasComboBox.Name = "vid_rasComboBox";
            this.vid_rasComboBox.Size = new System.Drawing.Size(121, 21);
            this.vid_rasComboBox.TabIndex = 8;
            // 
            // vidrasBindingSource
            // 
            this.vidrasBindingSource.DataMember = "Vid_ras";
            this.vidrasBindingSource.DataSource = this.bD_sDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // kolMaskedTextBox
            // 
            this.kolMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sost_rasBindingSource, "Kol", true));
            this.kolMaskedTextBox.Location = new System.Drawing.Point(154, 96);
            this.kolMaskedTextBox.Mask = "00000";
            this.kolMaskedTextBox.Name = "kolMaskedTextBox";
            this.kolMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.kolMaskedTextBox.TabIndex = 61;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 197);
            this.Controls.Add(this.kolMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(vid_rasLabel);
            this.Controls.Add(this.vid_rasComboBox);
            this.Controls.Add(kolLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(id_lim_kLabel);
            this.Controls.Add(this.id_lim_kComboBox);
            this.Controls.Add(this.sost_rasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form12";
            this.Text = "Состав расходов";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_rasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_rasBindingNavigator)).EndInit();
            this.sost_rasBindingNavigator.ResumeLayout(false);
            this.sost_rasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidrasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource sost_rasBindingSource;
        private BD_sDataSetTableAdapters.Sost_rasTableAdapter sost_rasTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sost_rasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sost_rasBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox id_lim_kComboBox;
        private BD_sDataSetTableAdapters.rasxodTableAdapter rasxodTableAdapter;
        private System.Windows.Forms.BindingSource rasxodBindingSource;
        private BD_sDataSetTableAdapters.Vid_rasTableAdapter vid_rasTableAdapter;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox vid_rasComboBox;
        private System.Windows.Forms.BindingSource vidrasBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox kolMaskedTextBox;
    }
}