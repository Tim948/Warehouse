﻿namespace kur_BD
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.Label nom_skladLabel;
            System.Windows.Forms.Label podrazLabel;
            System.Windows.Forms.Label tovarLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label limitLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.rasxodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rasxodTableAdapter = new kur_BD.BD_sDataSetTableAdapters.rasxodTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.rasxodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rasxodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nom_skladComboBox = new System.Windows.Forms.ComboBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.SkladTableAdapter();
            this.podrazTextBox = new System.Windows.Forms.TextBox();
            this.tovarComboBox = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new kur_BD.BD_sDataSetTableAdapters.TovarTableAdapter();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.limitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            nom_skladLabel = new System.Windows.Forms.Label();
            podrazLabel = new System.Windows.Forms.Label();
            tovarLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            limitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingNavigator)).BeginInit();
            this.rasxodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rasxodBindingSource
            // 
            this.rasxodBindingSource.DataMember = "rasxod";
            this.rasxodBindingSource.DataSource = this.bD_sDataSet;
            // 
            // rasxodTableAdapter
            // 
            this.rasxodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = this.rasxodTableAdapter;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.Sost_nakladTableAdapter = null;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = null;
            // 
            // rasxodBindingNavigator
            // 
            this.rasxodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rasxodBindingNavigator.BindingSource = this.rasxodBindingSource;
            this.rasxodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rasxodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rasxodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rasxodBindingNavigatorSaveItem});
            this.rasxodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rasxodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rasxodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rasxodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rasxodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rasxodBindingNavigator.Name = "rasxodBindingNavigator";
            this.rasxodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rasxodBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.rasxodBindingNavigator.TabIndex = 0;
            this.rasxodBindingNavigator.Text = "bindingNavigator1";
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
            // rasxodBindingNavigatorSaveItem
            // 
            this.rasxodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rasxodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rasxodBindingNavigatorSaveItem.Image")));
            this.rasxodBindingNavigatorSaveItem.Name = "rasxodBindingNavigatorSaveItem";
            this.rasxodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rasxodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rasxodBindingNavigatorSaveItem.Click += new System.EventHandler(this.rasxodBindingNavigatorSaveItem_Click);
            // 
            // nom_skladLabel
            // 
            nom_skladLabel.AutoSize = true;
            nom_skladLabel.Location = new System.Drawing.Point(12, 43);
            nom_skladLabel.Name = "nom_skladLabel";
            nom_skladLabel.Size = new System.Drawing.Size(83, 13);
            nom_skladLabel.TabIndex = 1;
            nom_skladLabel.Text = "Номер склада:";
            // 
            // nom_skladComboBox
            // 
            this.nom_skladComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rasxodBindingSource, "Nom_sklad", true));
            this.nom_skladComboBox.DataSource = this.skladBindingSource;
            this.nom_skladComboBox.DisplayMember = "id";
            this.nom_skladComboBox.FormattingEnabled = true;
            this.nom_skladComboBox.Location = new System.Drawing.Point(106, 40);
            this.nom_skladComboBox.Name = "nom_skladComboBox";
            this.nom_skladComboBox.Size = new System.Drawing.Size(121, 21);
            this.nom_skladComboBox.TabIndex = 2;
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
            // podrazLabel
            // 
            podrazLabel.AutoSize = true;
            podrazLabel.Location = new System.Drawing.Point(10, 70);
            podrazLabel.Name = "podrazLabel";
            podrazLabel.Size = new System.Drawing.Size(90, 13);
            podrazLabel.TabIndex = 3;
            podrazLabel.Text = "Подразделение:";
            // 
            // podrazTextBox
            // 
            this.podrazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rasxodBindingSource, "Podraz", true));
            this.podrazTextBox.Location = new System.Drawing.Point(106, 67);
            this.podrazTextBox.Name = "podrazTextBox";
            this.podrazTextBox.Size = new System.Drawing.Size(121, 20);
            this.podrazTextBox.TabIndex = 4;
            // 
            // tovarLabel
            // 
            tovarLabel.AutoSize = true;
            tovarLabel.Location = new System.Drawing.Point(59, 96);
            tovarLabel.Name = "tovarLabel";
            tovarLabel.Size = new System.Drawing.Size(41, 13);
            tovarLabel.TabIndex = 5;
            tovarLabel.Text = "Товар:";
            // 
            // tovarComboBox
            // 
            this.tovarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rasxodBindingSource, "Tovar", true));
            this.tovarComboBox.DataSource = this.tovarBindingSource;
            this.tovarComboBox.DisplayMember = "Id";
            this.tovarComboBox.FormattingEnabled = true;
            this.tovarComboBox.Location = new System.Drawing.Point(106, 93);
            this.tovarComboBox.Name = "tovarComboBox";
            this.tovarComboBox.Size = new System.Drawing.Size(121, 21);
            this.tovarComboBox.TabIndex = 6;
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
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(17, 120);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(83, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Дата продажи:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rasxodBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(106, 120);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // limitLabel
            // 
            limitLabel.AutoSize = true;
            limitLabel.Location = new System.Drawing.Point(57, 146);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new System.Drawing.Size(43, 13);
            limitLabel.TabIndex = 9;
            limitLabel.Text = "Лимит:";
            // 
            // limitTextBox
            // 
            this.limitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rasxodBindingSource, "Limit", true));
            this.limitTextBox.Location = new System.Drawing.Point(106, 146);
            this.limitTextBox.Name = "limitTextBox";
            this.limitTextBox.Size = new System.Drawing.Size(121, 20);
            this.limitTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(101, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 59;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(limitLabel);
            this.Controls.Add(this.limitTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(tovarLabel);
            this.Controls.Add(this.tovarComboBox);
            this.Controls.Add(podrazLabel);
            this.Controls.Add(this.podrazTextBox);
            this.Controls.Add(nom_skladLabel);
            this.Controls.Add(this.nom_skladComboBox);
            this.Controls.Add(this.rasxodBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Учёт товаров";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodBindingNavigator)).EndInit();
            this.rasxodBindingNavigator.ResumeLayout(false);
            this.rasxodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource rasxodBindingSource;
        private BD_sDataSetTableAdapters.rasxodTableAdapter rasxodTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rasxodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rasxodBindingNavigatorSaveItem;
        private BD_sDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.ComboBox nom_skladComboBox;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private BD_sDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.TextBox podrazTextBox;
        private System.Windows.Forms.ComboBox tovarComboBox;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox limitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}