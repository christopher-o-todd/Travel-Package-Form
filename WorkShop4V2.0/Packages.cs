using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversions;

namespace WorkShop4V2._0
{
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }
        bool validData = false;
        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            validData = false;
            if (
                Validator.IsPresent(pkgBasePriceTextBox) == true && Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) == true &&
                Validator.IsPresent(pkgNameTextBox) == true && Validator.IsPresent(pkgNameTextBox) == true &&
                Validator.IsPresent(pkgAgencyCommissionTextBox) == true && (Convert.ToDecimal(pkgAgencyCommissionTextBox.Text) < Convert.ToDecimal(pkgBasePriceTextBox.Text)) &&
                (pkgStartDateDateTimePicker.Value < pkgEndDateDateTimePicker.Value)
                
               )

            {
                validData = true;

            }
            else
            {
                validData = false;

            }

            //this.Validate();
            if (validData == true)
            {
                
                this.packagesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

            }
            else
            {
                MessageBox.Show("Data Entered Is Invalid", "Error");
            }


           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
           
            Products Product = new Products();
            Product.Show();
        }

        private void pkgBasePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkgBasePriceTextBox_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void btnAddLineItem_Click(object sender, EventArgs e)
        {
            int packID = Convert.ToInt32(packageIdTextBox.Text);
            
            if(cmbLineItems.Visible == false)
            {
                cmbLineItems.Visible = true;
                return;
            }
            
            else
            {
                try
                {
                    int LineItem = Convert.ToInt32(cmbLineItems.Text);
                    packages_Products_SuppliersTableAdapter.InsertLineItems(packID, LineItem);
                    this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
                }
                catch
                (SqlException ex)
                {
                    MessageBox.Show("Product Already Exists in this Package");
                }
           


            }

            

        }

        private void cmbLineItems_Click(object sender, EventArgs e)
        {
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);

        }

        
    }
}
