using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop4V2._0
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void products_SuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.products_SuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if(txtAddNewProduct.Visible == false)
            {
                txtAddNewProduct.Visible = true;

            }
            else
            {
                string prodName = txtAddNewProduct.Text;
                productsTableAdapter.AddNewProduct(prodName);
                productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            }
           
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            if(txtAddNewSupplier.Visible == false)
            {
                txtAddNewSupplier.Visible = true;
                lblSupName.Visible = true;
                lblSupplierID.Visible = true;
                txtSupID.Visible = true;


            }
            else
            {
                string supName = txtAddNewSupplier.Text;
                int supID = Convert.ToInt32(txtSupID.Text);

                suppliersTableAdapter.AddNewSupplier(supID, supName);
                this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);

            }
         
        }
    }
}
