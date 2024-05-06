using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305043.FORMS
{
    public partial class Main : Form
    {
        private MySQLDataAccess _dataAccess;

        public Main(MySQLDataAccess dataAccess)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users(_dataAccess);
            users.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            string brandName = txtBrand.Text.Trim();

            if (string.IsNullOrWhiteSpace(brandName))
            {
                MessageBox.Show("Please enter a brand name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowsAffected = _dataAccess.AddBrand(brandName);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Brand added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void btnPAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProduct.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter a product name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowsAffected = _dataAccess.AddProduct(productName);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
