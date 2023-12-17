namespace kur_BD
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label tip_nakLabel;
            System.Windows.Forms.Label nom_sLabel;
            System.Windows.Forms.Label postavLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.prixodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixodTableAdapter = new kur_BD.BD_sDataSetTableAdapters.PrixodTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.prixodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prixodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tip_nakComboBox = new System.Windows.Forms.ComboBox();
            this.nom_sComboBox = new System.Windows.Forms.ComboBox();
            this.postavComboBox = new System.Windows.Forms.ComboBox();
            this.sostnakladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sost_nakladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Sost_nakladTableAdapter();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.SkladTableAdapter();
            this.organBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organTableAdapter = new kur_BD.BD_sDataSetTableAdapters.OrganTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            tip_nakLabel = new System.Windows.Forms.Label();
            nom_sLabel = new System.Windows.Forms.Label();
            postavLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingNavigator)).BeginInit();
            this.prixodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sostnakladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prixodBindingSource
            // 
            this.prixodBindingSource.DataMember = "Prixod";
            this.prixodBindingSource.DataSource = this.bD_sDataSet;
            // 
            // prixodTableAdapter
            // 
            this.prixodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = this.organTableAdapter;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = this.prixodTableAdapter;
            this.tableAdapterManager.rasxodTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.Sost_nakladTableAdapter = this.sost_nakladTableAdapter;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = null;
            // 
            // prixodBindingNavigator
            // 
            this.prixodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prixodBindingNavigator.BindingSource = this.prixodBindingSource;
            this.prixodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prixodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prixodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prixodBindingNavigatorSaveItem});
            this.prixodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prixodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prixodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prixodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prixodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prixodBindingNavigator.Name = "prixodBindingNavigator";
            this.prixodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prixodBindingNavigator.Size = new System.Drawing.Size(289, 25);
            this.prixodBindingNavigator.TabIndex = 0;
            this.prixodBindingNavigator.Text = "bindingNavigator1";
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
            // prixodBindingNavigatorSaveItem
            // 
            this.prixodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prixodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prixodBindingNavigatorSaveItem.Image")));
            this.prixodBindingNavigatorSaveItem.Name = "prixodBindingNavigatorSaveItem";
            this.prixodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.prixodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prixodBindingNavigatorSaveItem.Click += new System.EventHandler(this.prixodBindingNavigatorSaveItem_Click);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 49);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(39, 13);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата :";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prixodBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(57, 43);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // tip_nakLabel
            // 
            tip_nakLabel.AutoSize = true;
            tip_nakLabel.Location = new System.Drawing.Point(12, 75);
            tip_nakLabel.Name = "tip_nakLabel";
            tip_nakLabel.Size = new System.Drawing.Size(101, 13);
            tip_nakLabel.TabIndex = 3;
            tip_nakLabel.Text = "Номер накладной:";
            // 
            // tip_nakComboBox
            // 
            this.tip_nakComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prixodBindingSource, "tip_nak", true));
            this.tip_nakComboBox.DataSource = this.sostnakladBindingSource;
            this.tip_nakComboBox.DisplayMember = "id";
            this.tip_nakComboBox.FormattingEnabled = true;
            this.tip_nakComboBox.Location = new System.Drawing.Point(119, 72);
            this.tip_nakComboBox.Name = "tip_nakComboBox";
            this.tip_nakComboBox.Size = new System.Drawing.Size(138, 21);
            this.tip_nakComboBox.TabIndex = 4;
            // 
            // nom_sLabel
            // 
            nom_sLabel.AutoSize = true;
            nom_sLabel.Location = new System.Drawing.Point(47, 102);
            nom_sLabel.Name = "nom_sLabel";
            nom_sLabel.Size = new System.Drawing.Size(83, 13);
            nom_sLabel.TabIndex = 5;
            nom_sLabel.Text = "Номер склада:";
            // 
            // nom_sComboBox
            // 
            this.nom_sComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prixodBindingSource, "nom_s", true));
            this.nom_sComboBox.DataSource = this.skladBindingSource;
            this.nom_sComboBox.DisplayMember = "id";
            this.nom_sComboBox.FormattingEnabled = true;
            this.nom_sComboBox.Location = new System.Drawing.Point(136, 99);
            this.nom_sComboBox.Name = "nom_sComboBox";
            this.nom_sComboBox.Size = new System.Drawing.Size(121, 21);
            this.nom_sComboBox.TabIndex = 6;
            // 
            // postavLabel
            // 
            postavLabel.AutoSize = true;
            postavLabel.Location = new System.Drawing.Point(21, 126);
            postavLabel.Name = "postavLabel";
            postavLabel.Size = new System.Drawing.Size(109, 13);
            postavLabel.TabIndex = 7;
            postavLabel.Text = "Номер поставщика:";
            // 
            // postavComboBox
            // 
            this.postavComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prixodBindingSource, "Postav", true));
            this.postavComboBox.DataSource = this.organBindingSource;
            this.postavComboBox.DisplayMember = "id";
            this.postavComboBox.FormattingEnabled = true;
            this.postavComboBox.Location = new System.Drawing.Point(136, 126);
            this.postavComboBox.Name = "postavComboBox";
            this.postavComboBox.Size = new System.Drawing.Size(121, 21);
            this.postavComboBox.TabIndex = 8;
            // 
            // sostnakladBindingSource
            // 
            this.sostnakladBindingSource.DataMember = "Sost_naklad";
            this.sostnakladBindingSource.DataSource = this.bD_sDataSet;
            // 
            // sost_nakladTableAdapter
            // 
            this.sost_nakladTableAdapter.ClearBeforeFill = true;
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
            // organBindingSource
            // 
            this.organBindingSource.DataMember = "Organ";
            this.organBindingSource.DataSource = this.bD_sDataSet;
            // 
            // organTableAdapter
            // 
            this.organTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(103, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 59;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(postavLabel);
            this.Controls.Add(this.postavComboBox);
            this.Controls.Add(nom_sLabel);
            this.Controls.Add(this.nom_sComboBox);
            this.Controls.Add(tip_nakLabel);
            this.Controls.Add(this.tip_nakComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.prixodBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.Text = "Приход товаров";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixodBindingNavigator)).EndInit();
            this.prixodBindingNavigator.ResumeLayout(false);
            this.prixodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sostnakladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource prixodBindingSource;
        private BD_sDataSetTableAdapters.PrixodTableAdapter prixodTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prixodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prixodBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private BD_sDataSetTableAdapters.Sost_nakladTableAdapter sost_nakladTableAdapter;
        private System.Windows.Forms.ComboBox tip_nakComboBox;
        private System.Windows.Forms.ComboBox nom_sComboBox;
        private System.Windows.Forms.ComboBox postavComboBox;
        private System.Windows.Forms.BindingSource sostnakladBindingSource;
        private BD_sDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private BD_sDataSetTableAdapters.OrganTableAdapter organTableAdapter;
        private System.Windows.Forms.BindingSource organBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}