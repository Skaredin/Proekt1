
namespace v3.Properties
{
    partial class SaleProduct
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label clientServiceIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleProduct));
            this.dv3_403DataSet = new v3.dv3_403DataSet();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleTableAdapter = new v3.dv3_403DataSetTableAdapters.ProductSaleTableAdapter();
            this.tableAdapterManager = new v3.dv3_403DataSetTableAdapters.TableAdapterManager();
            this.productSaleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productSaleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.clientServiceIDTextBox = new System.Windows.Forms.TextBox();
            this.productSaleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            clientServiceIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv3_403DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingNavigator)).BeginInit();
            this.productSaleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(66, 93);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(66, 120);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(57, 13);
            saleDateLabel.TabIndex = 3;
            saleDateLabel.Text = "Sale Date:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(66, 145);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 5;
            productIDLabel.Text = "Product ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(66, 172);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity:";
            // 
            // clientServiceIDLabel
            // 
            clientServiceIDLabel.AutoSize = true;
            clientServiceIDLabel.Location = new System.Drawing.Point(66, 198);
            clientServiceIDLabel.Name = "clientServiceIDLabel";
            clientServiceIDLabel.Size = new System.Drawing.Size(89, 13);
            clientServiceIDLabel.TabIndex = 9;
            clientServiceIDLabel.Text = "Client Service ID:";
            // 
            // dv3_403DataSet
            // 
            this.dv3_403DataSet.DataSetName = "dv3_403DataSet";
            this.dv3_403DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataMember = "ProductSale";
            this.productSaleBindingSource.DataSource = this.dv3_403DataSet;
            // 
            // productSaleTableAdapter
            // 
            this.productSaleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = this.productSaleTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = v3.dv3_403DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productSaleBindingNavigator
            // 
            this.productSaleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productSaleBindingNavigator.BindingSource = this.productSaleBindingSource;
            this.productSaleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productSaleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productSaleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productSaleBindingNavigatorSaveItem});
            this.productSaleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productSaleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productSaleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productSaleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productSaleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productSaleBindingNavigator.Name = "productSaleBindingNavigator";
            this.productSaleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productSaleBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.productSaleBindingNavigator.TabIndex = 0;
            this.productSaleBindingNavigator.Text = "bindingNavigator1";
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
            // productSaleBindingNavigatorSaveItem
            // 
            this.productSaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productSaleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productSaleBindingNavigatorSaveItem.Image")));
            this.productSaleBindingNavigatorSaveItem.Name = "productSaleBindingNavigatorSaveItem";
            this.productSaleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productSaleBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productSaleBindingNavigatorSaveItem.Click += new System.EventHandler(this.productSaleBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(161, 90);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(161, 116);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.saleDateDateTimePicker.TabIndex = 4;
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ProductID", true));
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(161, 142);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.productIDComboBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(161, 169);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // clientServiceIDTextBox
            // 
            this.clientServiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ClientServiceID", true));
            this.clientServiceIDTextBox.Location = new System.Drawing.Point(161, 195);
            this.clientServiceIDTextBox.Name = "clientServiceIDTextBox";
            this.clientServiceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientServiceIDTextBox.TabIndex = 10;
            // 
            // productSaleDataGridView
            // 
            this.productSaleDataGridView.AllowUserToAddRows = false;
            this.productSaleDataGridView.AllowUserToDeleteRows = false;
            this.productSaleDataGridView.AutoGenerateColumns = false;
            this.productSaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productSaleDataGridView.DataSource = this.productSaleBindingSource;
            this.productSaleDataGridView.Location = new System.Drawing.Point(39, 232);
            this.productSaleDataGridView.Name = "productSaleDataGridView";
            this.productSaleDataGridView.ReadOnly = true;
            this.productSaleDataGridView.Size = new System.Drawing.Size(349, 220);
            this.productSaleDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "SaleDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(313, 474);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 509);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.productSaleDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(saleDateLabel);
            this.Controls.Add(this.saleDateDateTimePicker);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(clientServiceIDLabel);
            this.Controls.Add(this.clientServiceIDTextBox);
            this.Controls.Add(this.productSaleBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleProduct";
            this.Text = "Автосервис \"Доеду сам\"";
            this.Load += new System.EventHandler(this.SaleProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv3_403DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingNavigator)).EndInit();
            this.productSaleBindingNavigator.ResumeLayout(false);
            this.productSaleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dv3_403DataSet dv3_403DataSet;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private dv3_403DataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
        private dv3_403DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productSaleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productSaleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox clientServiceIDTextBox;
        private System.Windows.Forms.DataGridView productSaleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button exitBtn;
    }
}