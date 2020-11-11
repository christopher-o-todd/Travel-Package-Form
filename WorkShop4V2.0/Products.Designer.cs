namespace WorkShop4V2._0
{
    partial class Products
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
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.travelExpertsDataSet = new WorkShop4V2._0.TravelExpertsDataSet();
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersTableAdapter = new WorkShop4V2._0.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.tableAdapterManager = new WorkShop4V2._0.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.packages_Products_SuppliersTableAdapter = new WorkShop4V2._0.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.productsTableAdapter = new WorkShop4V2._0.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new WorkShop4V2._0.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.products_SuppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.products_SuppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesProductsSupplieFK01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.txtAddNewProduct = new System.Windows.Forms.TextBox();
            this.btnAddNewSupplier = new System.Windows.Forms.Button();
            this.txtAddNewSupplier = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).BeginInit();
            this.products_SuppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSupplieFK01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(9, 39);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(100, 13);
            productSupplierIdLabel.TabIndex = 1;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(9, 62);
            productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(59, 13);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Id:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(9, 87);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 13);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // products_SuppliersBindingSource
            // 
            this.products_SuppliersBindingSource.DataMember = "Products_Suppliers";
            this.products_SuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = this.packages_Products_SuppliersTableAdapter;
            this.tableAdapterManager.PackagesTableAdapter = null;
            this.tableAdapterManager.Products_SuppliersTableAdapter = this.products_SuppliersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WorkShop4V2._0.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // packages_Products_SuppliersTableAdapter
            // 
            this.packages_Products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // products_SuppliersBindingNavigator
            // 
            this.products_SuppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.products_SuppliersBindingNavigator.BindingSource = this.products_SuppliersBindingSource;
            this.products_SuppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.products_SuppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.products_SuppliersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.products_SuppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.products_SuppliersBindingNavigatorSaveItem});
            this.products_SuppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.products_SuppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.products_SuppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.products_SuppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.products_SuppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.products_SuppliersBindingNavigator.Name = "products_SuppliersBindingNavigator";
            this.products_SuppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.products_SuppliersBindingNavigator.Size = new System.Drawing.Size(419, 27);
            this.products_SuppliersBindingNavigator.TabIndex = 0;
            this.products_SuppliersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // products_SuppliersBindingNavigatorSaveItem
            // 
            this.products_SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.products_SuppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("products_SuppliersBindingNavigatorSaveItem.Image")));
            this.products_SuppliersBindingNavigatorSaveItem.Name = "products_SuppliersBindingNavigatorSaveItem";
            this.products_SuppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.products_SuppliersBindingNavigatorSaveItem.Text = "Save Data";
            this.products_SuppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.products_SuppliersBindingNavigatorSaveItem_Click);
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SuppliersBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(112, 37);
            this.productSupplierIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(255, 20);
            this.productSupplierIdTextBox.TabIndex = 2;
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SuppliersBindingSource, "ProductId", true));
            this.productIdComboBox.DataSource = this.productsBindingSource;
            this.productIdComboBox.DisplayMember = "ProdName";
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(112, 59);
            this.productIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(255, 21);
            this.productIdComboBox.TabIndex = 4;
            this.productIdComboBox.ValueMember = "ProductId";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SuppliersBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.suppliersBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupName";
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(112, 84);
            this.supplierIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(255, 21);
            this.supplierIdComboBox.TabIndex = 6;
            this.supplierIdComboBox.ValueMember = "SupplierId";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesProductsSupplieFK01BindingSource
            // 
            this.packagesProductsSupplieFK01BindingSource.DataMember = "Packages_Products_Supplie_FK01";
            this.packagesProductsSupplieFK01BindingSource.DataSource = this.products_SuppliersBindingSource;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.Tan;
            this.btnAddNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewProduct.Location = new System.Drawing.Point(11, 129);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(122, 19);
            this.btnAddNewProduct.TabIndex = 7;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // txtAddNewProduct
            // 
            this.txtAddNewProduct.Location = new System.Drawing.Point(152, 130);
            this.txtAddNewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddNewProduct.Name = "txtAddNewProduct";
            this.txtAddNewProduct.Size = new System.Drawing.Size(137, 20);
            this.txtAddNewProduct.TabIndex = 8;
            this.txtAddNewProduct.Visible = false;
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.BackColor = System.Drawing.Color.Tan;
            this.btnAddNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewSupplier.Location = new System.Drawing.Point(12, 186);
            this.btnAddNewSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(122, 19);
            this.btnAddNewSupplier.TabIndex = 9;
            this.btnAddNewSupplier.Text = "Add New Supplier";
            this.btnAddNewSupplier.UseVisualStyleBackColor = false;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // txtAddNewSupplier
            // 
            this.txtAddNewSupplier.Location = new System.Drawing.Point(94, 217);
            this.txtAddNewSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddNewSupplier.Name = "txtAddNewSupplier";
            this.txtAddNewSupplier.Size = new System.Drawing.Size(137, 20);
            this.txtAddNewSupplier.TabIndex = 10;
            this.txtAddNewSupplier.Visible = false;
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(94, 247);
            this.txtSupID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(137, 20);
            this.txtSupID.TabIndex = 11;
            this.txtSupID.Visible = false;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(14, 251);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(56, 13);
            this.lblSupplierID.TabIndex = 12;
            this.lblSupplierID.Text = "SupplierID";
            this.lblSupplierID.Visible = false;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(14, 221);
            this.lblSupName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(76, 13);
            this.lblSupName.TabIndex = 13;
            this.lblSupName.Text = "Supplier Name";
            this.lblSupName.Visible = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(419, 323);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.txtAddNewSupplier);
            this.Controls.Add(this.btnAddNewSupplier);
            this.Controls.Add(this.txtAddNewProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(this.productSupplierIdTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdComboBox);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdComboBox);
            this.Controls.Add(this.products_SuppliersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Products";
            this.Text = "New Product or Supplier";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingNavigator)).EndInit();
            this.products_SuppliersBindingNavigator.ResumeLayout(false);
            this.products_SuppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSupplieFK01BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator products_SuppliersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton products_SuppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource packagesProductsSupplieFK01BindingSource;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.TextBox txtAddNewProduct;
        private System.Windows.Forms.Button btnAddNewSupplier;
        private System.Windows.Forms.TextBox txtAddNewSupplier;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblSupName;
    }
}