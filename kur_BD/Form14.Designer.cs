namespace kur_BD
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            System.Windows.Forms.Label artLabel;
            System.Windows.Forms.Label kolLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.sost_nakladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sost_nakladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Sost_nakladTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.sost_nakladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sost_nakladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.artComboBox = new System.Windows.Forms.ComboBox();
            this.kolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new kur_BD.BD_sDataSetTableAdapters.TovarTableAdapter();
            artLabel = new System.Windows.Forms.Label();
            kolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_nakladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_nakladBindingNavigator)).BeginInit();
            this.sost_nakladBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sost_nakladBindingSource
            // 
            this.sost_nakladBindingSource.DataMember = "Sost_naklad";
            this.sost_nakladBindingSource.DataSource = this.bD_sDataSet;
            // 
            // sost_nakladTableAdapter
            // 
            this.sost_nakladTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.Sost_nakladTableAdapter = this.sost_nakladTableAdapter;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = null;
            // 
            // sost_nakladBindingNavigator
            // 
            this.sost_nakladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sost_nakladBindingNavigator.BindingSource = this.sost_nakladBindingSource;
            this.sost_nakladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sost_nakladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sost_nakladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sost_nakladBindingNavigatorSaveItem});
            this.sost_nakladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sost_nakladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sost_nakladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sost_nakladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sost_nakladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sost_nakladBindingNavigator.Name = "sost_nakladBindingNavigator";
            this.sost_nakladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sost_nakladBindingNavigator.Size = new System.Drawing.Size(289, 25);
            this.sost_nakladBindingNavigator.TabIndex = 0;
            this.sost_nakladBindingNavigator.Text = "bindingNavigator1";
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
            // sost_nakladBindingNavigatorSaveItem
            // 
            this.sost_nakladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sost_nakladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sost_nakladBindingNavigatorSaveItem.Image")));
            this.sost_nakladBindingNavigatorSaveItem.Name = "sost_nakladBindingNavigatorSaveItem";
            this.sost_nakladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sost_nakladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sost_nakladBindingNavigatorSaveItem.Click += new System.EventHandler(this.sost_nakladBindingNavigatorSaveItem_Click);
            // 
            // artLabel
            // 
            artLabel.AutoSize = true;
            artLabel.Location = new System.Drawing.Point(12, 42);
            artLabel.Name = "artLabel";
            artLabel.Size = new System.Drawing.Size(82, 13);
            artLabel.TabIndex = 1;
            artLabel.Text = "Номер товара:";
            // 
            // artComboBox
            // 
            this.artComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sost_nakladBindingSource, "art", true));
            this.artComboBox.DataSource = this.tovarBindingSource;
            this.artComboBox.DisplayMember = "Id";
            this.artComboBox.FormattingEnabled = true;
            this.artComboBox.Location = new System.Drawing.Point(100, 39);
            this.artComboBox.Name = "artComboBox";
            this.artComboBox.Size = new System.Drawing.Size(121, 21);
            this.artComboBox.TabIndex = 2;
            // 
            // kolLabel
            // 
            kolLabel.AutoSize = true;
            kolLabel.Location = new System.Drawing.Point(25, 65);
            kolLabel.Name = "kolLabel";
            kolLabel.Size = new System.Drawing.Size(69, 13);
            kolLabel.TabIndex = 3;
            kolLabel.Text = "Количество:";
            // 
            // kolTextBox
            // 
            this.kolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sost_nakladBindingSource, "Kol", true));
            this.kolTextBox.Location = new System.Drawing.Point(100, 65);
            this.kolTextBox.Name = "kolTextBox";
            this.kolTextBox.Size = new System.Drawing.Size(121, 20);
            this.kolTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
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
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(kolLabel);
            this.Controls.Add(this.kolTextBox);
            this.Controls.Add(artLabel);
            this.Controls.Add(this.artComboBox);
            this.Controls.Add(this.sost_nakladBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.Text = "Состав накладной";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_nakladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sost_nakladBindingNavigator)).EndInit();
            this.sost_nakladBindingNavigator.ResumeLayout(false);
            this.sost_nakladBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource sost_nakladBindingSource;
        private BD_sDataSetTableAdapters.Sost_nakladTableAdapter sost_nakladTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sost_nakladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sost_nakladBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox artComboBox;
        private System.Windows.Forms.TextBox kolTextBox;
        private BD_sDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tovarBindingSource;
    }
}