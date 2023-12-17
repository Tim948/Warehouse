namespace kur_BD
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label id_sLabel;
            System.Windows.Forms.Label artLabel;
            System.Windows.Forms.Label kolLabel;
            System.Windows.Forms.Label dateLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.ost_sBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ost_sTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Ost_sTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.ost_sBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ost_sBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kolTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_sComboBox = new System.Windows.Forms.ComboBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.SkladTableAdapter();
            this.artComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new kur_BD.BD_sDataSetTableAdapters.TovarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            id_sLabel = new System.Windows.Forms.Label();
            artLabel = new System.Windows.Forms.Label();
            kolLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ost_sBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ost_sBindingNavigator)).BeginInit();
            this.ost_sBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ost_sBindingSource
            // 
            this.ost_sBindingSource.DataMember = "Ost_s";
            this.ost_sBindingSource.DataSource = this.bD_sDataSet;
            // 
            // ost_sTableAdapter
            // 
            this.ost_sTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = this.ost_sTableAdapter;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.Sost_nakladTableAdapter = null;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = null;
            // 
            // ost_sBindingNavigator
            // 
            this.ost_sBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ost_sBindingNavigator.BindingSource = this.ost_sBindingSource;
            this.ost_sBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ost_sBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ost_sBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ost_sBindingNavigatorSaveItem});
            this.ost_sBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ost_sBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ost_sBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ost_sBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ost_sBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ost_sBindingNavigator.Name = "ost_sBindingNavigator";
            this.ost_sBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ost_sBindingNavigator.Size = new System.Drawing.Size(290, 25);
            this.ost_sBindingNavigator.TabIndex = 0;
            this.ost_sBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // ost_sBindingNavigatorSaveItem
            // 
            this.ost_sBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ost_sBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ost_sBindingNavigatorSaveItem.Image")));
            this.ost_sBindingNavigatorSaveItem.Name = "ost_sBindingNavigatorSaveItem";
            this.ost_sBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ost_sBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ost_sBindingNavigatorSaveItem.Click += new System.EventHandler(this.ost_sBindingNavigatorSaveItem_Click);
            // 
            // id_sLabel
            // 
            id_sLabel.AutoSize = true;
            id_sLabel.Location = new System.Drawing.Point(12, 58);
            id_sLabel.Name = "id_sLabel";
            id_sLabel.Size = new System.Drawing.Size(83, 13);
            id_sLabel.TabIndex = 1;
            id_sLabel.Text = "Номер склада:";
            // 
            // artLabel
            // 
            artLabel.AutoSize = true;
            artLabel.Location = new System.Drawing.Point(12, 85);
            artLabel.Name = "artLabel";
            artLabel.Size = new System.Drawing.Size(95, 13);
            artLabel.TabIndex = 3;
            artLabel.Text = "Артикул товрара:";
            // 
            // kolLabel
            // 
            kolLabel.AutoSize = true;
            kolLabel.Location = new System.Drawing.Point(32, 109);
            kolLabel.Name = "kolLabel";
            kolLabel.Size = new System.Drawing.Size(75, 13);
            kolLabel.TabIndex = 5;
            kolLabel.Text = "Колличество:";
            // 
            // kolTextBox
            // 
            this.kolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ost_sBindingSource, "Kol", true));
            this.kolTextBox.Location = new System.Drawing.Point(113, 106);
            this.kolTextBox.Name = "kolTextBox";
            this.kolTextBox.Size = new System.Drawing.Size(121, 20);
            this.kolTextBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(4, 135);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(103, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Дата поступления:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ost_sBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(113, 135);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // id_sComboBox
            // 
            this.id_sComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ost_sBindingSource, "id_s", true));
            this.id_sComboBox.DataSource = this.skladBindingSource;
            this.id_sComboBox.DisplayMember = "id";
            this.id_sComboBox.FormattingEnabled = true;
            this.id_sComboBox.Location = new System.Drawing.Point(113, 55);
            this.id_sComboBox.Name = "id_sComboBox";
            this.id_sComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_sComboBox.TabIndex = 9;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.bD_sDataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // artComboBox
            // 
            this.artComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ost_sBindingSource, "art", true));
            this.artComboBox.DataSource = this.tovarBindingSource;
            this.artComboBox.DisplayMember = "Id";
            this.artComboBox.FormattingEnabled = true;
            this.artComboBox.Location = new System.Drawing.Point(113, 82);
            this.artComboBox.Name = "artComboBox";
            this.artComboBox.Size = new System.Drawing.Size(121, 21);
            this.artComboBox.TabIndex = 10;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.bD_sDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(101, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 59;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.artComboBox);
            this.Controls.Add(this.id_sComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(kolLabel);
            this.Controls.Add(this.kolTextBox);
            this.Controls.Add(artLabel);
            this.Controls.Add(id_sLabel);
            this.Controls.Add(this.ost_sBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Остаток на складе";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ost_sBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ost_sBindingNavigator)).EndInit();
            this.ost_sBindingNavigator.ResumeLayout(false);
            this.ost_sBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource ost_sBindingSource;
        private BD_sDataSetTableAdapters.Ost_sTableAdapter ost_sTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ost_sBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ost_sBindingNavigatorSaveItem;
        private BD_sDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.TextBox kolTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox id_sComboBox;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private BD_sDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.ComboBox artComboBox;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}