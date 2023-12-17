namespace kur_BD
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            System.Windows.Forms.Label naimLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.vid_rasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vid_rasTableAdapter = new kur_BD.BD_sDataSetTableAdapters.Vid_rasTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.vid_rasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vid_rasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.naimTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            naimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_rasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_rasBindingNavigator)).BeginInit();
            this.vid_rasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vid_rasBindingSource
            // 
            this.vid_rasBindingSource.DataMember = "Vid_ras";
            this.vid_rasBindingSource.DataSource = this.bD_sDataSet;
            // 
            // vid_rasTableAdapter
            // 
            this.vid_rasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.Sost_nakladTableAdapter = null;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = this.vid_rasTableAdapter;
            // 
            // vid_rasBindingNavigator
            // 
            this.vid_rasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vid_rasBindingNavigator.BindingSource = this.vid_rasBindingSource;
            this.vid_rasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vid_rasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vid_rasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vid_rasBindingNavigatorSaveItem});
            this.vid_rasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vid_rasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vid_rasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vid_rasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vid_rasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vid_rasBindingNavigator.Name = "vid_rasBindingNavigator";
            this.vid_rasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vid_rasBindingNavigator.Size = new System.Drawing.Size(336, 25);
            this.vid_rasBindingNavigator.TabIndex = 0;
            this.vid_rasBindingNavigator.Text = "bindingNavigator1";
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
            // vid_rasBindingNavigatorSaveItem
            // 
            this.vid_rasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vid_rasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vid_rasBindingNavigatorSaveItem.Image")));
            this.vid_rasBindingNavigatorSaveItem.Name = "vid_rasBindingNavigatorSaveItem";
            this.vid_rasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vid_rasBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vid_rasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vid_rasBindingNavigatorSaveItem_Click);
            // 
            // naimLabel
            // 
            naimLabel.AutoSize = true;
            naimLabel.Location = new System.Drawing.Point(12, 50);
            naimLabel.Name = "naimLabel";
            naimLabel.Size = new System.Drawing.Size(104, 13);
            naimLabel.TabIndex = 1;
            naimLabel.Text = "Название расхода:";
            // 
            // naimTextBox
            // 
            this.naimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vid_rasBindingSource, "Naim", true));
            this.naimTextBox.Location = new System.Drawing.Point(122, 50);
            this.naimTextBox.Name = "naimTextBox";
            this.naimTextBox.Size = new System.Drawing.Size(202, 20);
            this.naimTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(naimLabel);
            this.Controls.Add(this.naimTextBox);
            this.Controls.Add(this.vid_rasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.Text = "Виды расходов";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_rasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_rasBindingNavigator)).EndInit();
            this.vid_rasBindingNavigator.ResumeLayout(false);
            this.vid_rasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource vid_rasBindingSource;
        private BD_sDataSetTableAdapters.Vid_rasTableAdapter vid_rasTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vid_rasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vid_rasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox naimTextBox;
        private System.Windows.Forms.Label label1;
    }
}