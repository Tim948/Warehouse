namespace kur_BD
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label naim_skladLabel;
            System.Windows.Forms.Label f_kLabel;
            System.Windows.Forms.Label im_kLabel;
            System.Windows.Forms.Label ot_kLabel;
            this.bD_sDataSet = new kur_BD.BD_sDataSet();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new kur_BD.BD_sDataSetTableAdapters.SkladTableAdapter();
            this.tableAdapterManager = new kur_BD.BD_sDataSetTableAdapters.TableAdapterManager();
            this.skladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.skladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.naim_skladTextBox = new System.Windows.Forms.TextBox();
            this.f_kTextBox = new System.Windows.Forms.TextBox();
            this.im_kTextBox = new System.Windows.Forms.TextBox();
            this.ot_kTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            naim_skladLabel = new System.Windows.Forms.Label();
            f_kLabel = new System.Windows.Forms.Label();
            im_kLabel = new System.Windows.Forms.Label();
            ot_kLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).BeginInit();
            this.skladBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_sDataSet
            // 
            this.bD_sDataSet.DataSetName = "BD_sDataSet";
            this.bD_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrganTableAdapter = null;
            this.tableAdapterManager.Ost_sTableAdapter = null;
            this.tableAdapterManager.PrixodTableAdapter = null;
            this.tableAdapterManager.rasxodTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.Sost_nakladTableAdapter = null;
            this.tableAdapterManager.Sost_rasTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kur_BD.BD_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_rasTableAdapter = null;
            // 
            // skladBindingNavigator
            // 
            this.skladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skladBindingNavigator.BindingSource = this.skladBindingSource;
            this.skladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.skladBindingNavigatorSaveItem});
            this.skladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skladBindingNavigator.Name = "skladBindingNavigator";
            this.skladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skladBindingNavigator.Size = new System.Drawing.Size(291, 25);
            this.skladBindingNavigator.TabIndex = 0;
            this.skladBindingNavigator.Text = "bindingNavigator1";
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
            // skladBindingNavigatorSaveItem
            // 
            this.skladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skladBindingNavigatorSaveItem.Image")));
            this.skladBindingNavigatorSaveItem.Name = "skladBindingNavigatorSaveItem";
            this.skladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.skladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.skladBindingNavigatorSaveItem.Click += new System.EventHandler(this.skladBindingNavigatorSaveItem_Click);
            // 
            // naim_skladLabel
            // 
            naim_skladLabel.AutoSize = true;
            naim_skladLabel.Location = new System.Drawing.Point(21, 45);
            naim_skladLabel.Name = "naim_skladLabel";
            naim_skladLabel.Size = new System.Drawing.Size(99, 13);
            naim_skladLabel.TabIndex = 1;
            naim_skladLabel.Text = "Название склада:";
            // 
            // naim_skladTextBox
            // 
            this.naim_skladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "naim_sklad", true));
            this.naim_skladTextBox.Location = new System.Drawing.Point(126, 42);
            this.naim_skladTextBox.Name = "naim_skladTextBox";
            this.naim_skladTextBox.Size = new System.Drawing.Size(153, 20);
            this.naim_skladTextBox.TabIndex = 2;
            // 
            // f_kLabel
            // 
            f_kLabel.AutoSize = true;
            f_kLabel.Location = new System.Drawing.Point(21, 69);
            f_kLabel.Name = "f_kLabel";
            f_kLabel.Size = new System.Drawing.Size(125, 13);
            f_kLabel.TabIndex = 3;
            f_kLabel.Text = "Фамилия кладовщика:";
            // 
            // f_kTextBox
            // 
            this.f_kTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "F_k", true));
            this.f_kTextBox.Location = new System.Drawing.Point(152, 68);
            this.f_kTextBox.Name = "f_kTextBox";
            this.f_kTextBox.Size = new System.Drawing.Size(127, 20);
            this.f_kTextBox.TabIndex = 4;
            // 
            // im_kLabel
            // 
            im_kLabel.AutoSize = true;
            im_kLabel.Location = new System.Drawing.Point(21, 97);
            im_kLabel.Name = "im_kLabel";
            im_kLabel.Size = new System.Drawing.Size(98, 13);
            im_kLabel.TabIndex = 5;
            im_kLabel.Text = "Имя кладовщика:";
            // 
            // im_kTextBox
            // 
            this.im_kTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Im_k", true));
            this.im_kTextBox.Location = new System.Drawing.Point(125, 94);
            this.im_kTextBox.Name = "im_kTextBox";
            this.im_kTextBox.Size = new System.Drawing.Size(154, 20);
            this.im_kTextBox.TabIndex = 6;
            // 
            // ot_kLabel
            // 
            ot_kLabel.AutoSize = true;
            ot_kLabel.Location = new System.Drawing.Point(21, 123);
            ot_kLabel.Name = "ot_kLabel";
            ot_kLabel.Size = new System.Drawing.Size(123, 13);
            ot_kLabel.TabIndex = 7;
            ot_kLabel.Text = "Отчество кладовщика:";
            // 
            // ot_kTextBox
            // 
            this.ot_kTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Ot_k", true));
            this.ot_kTextBox.Location = new System.Drawing.Point(150, 120);
            this.ot_kTextBox.Name = "ot_kTextBox";
            this.ot_kTextBox.Size = new System.Drawing.Size(129, 20);
            this.ot_kTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(100, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 59;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(ot_kLabel);
            this.Controls.Add(this.ot_kTextBox);
            this.Controls.Add(im_kLabel);
            this.Controls.Add(this.im_kTextBox);
            this.Controls.Add(f_kLabel);
            this.Controls.Add(this.f_kTextBox);
            this.Controls.Add(naim_skladLabel);
            this.Controls.Add(this.naim_skladTextBox);
            this.Controls.Add(this.skladBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Добавление информации";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).EndInit();
            this.skladBindingNavigator.ResumeLayout(false);
            this.skladBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_sDataSet bD_sDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private BD_sDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private BD_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton skladBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox naim_skladTextBox;
        private System.Windows.Forms.TextBox f_kTextBox;
        private System.Windows.Forms.TextBox im_kTextBox;
        private System.Windows.Forms.TextBox ot_kTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}