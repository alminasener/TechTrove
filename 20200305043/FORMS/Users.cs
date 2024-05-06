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
    public partial class Users : Form
    {
        private MySQLDataAccess _dataAccess;

        public Users(MySQLDataAccess dataAccess)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
        }
        private void Users_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void TechTrove_Click(object sender, EventArgs e)
        {
            Main main = new Main(_dataAccess);
            main.Show();
            this.Hide();
        }

        private void btnUAdd_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı, email ve şifre boş mu kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Alanlar boş ise işlemi sonlandır
            }

            try
            {
                int rowsAffected = _dataAccess.AddUser(txtUser.Text, txtEmail.Text, txtPwd.Text);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the user: " + ex.Message);
            }
        }

    }
}
